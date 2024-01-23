using MQTTnet.Client;
using MQTTnet.Extensions.ManagedClient;
using MQTTnet;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MetroCansDeviceSimulator
{
    public partial class MainView : Form
    {
        private static IMqttClient mqttClient;
        public bool Status { get; set; } = false;
        public MainView()
        {
            InitializeComponent();
            InitUI();
            SwitchMQTTStatus(status: true);
        }

        public void InitUI()
        {
            btn_start.Enabled = true;
            btn_stop.Enabled = false;
            txt_mqtt_host.Text = MQTTConfig.Host;
            txt_mqtt_publish_topic.Text = MQTTConfig.Topic_Telemetry;
            txt_device_name.Text = Config.DeviceName;
            txt_mqtt_username.Text = MQTTConfig.Username;

            for (int i = 0; i < 5; i++)
            {
                string rcp_name = $"aoi-{i}.rcp";
                dgv_recipe_list.Rows.Add(rcp_name);
            }

        }

        public async Task Disconnect()
        {
            if (mqttClient != null)
            {
                if (mqttClient.IsConnected)
                {
                    await mqttClient.DisconnectAsync();
                    Log("Disconnected", Color.Red);
                }
            }
        }

        public async Task<bool> Connect(string server)
        {
            if (mqttClient == null)
            {
                mqttClient = CreateMqttClient();
            }
            var mqttClientOptions = new MqttClientOptionsBuilder().
                WithTcpServer(server).
                WithCredentials(MQTTConfig.Username, "").
                Build();
            var response = await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);
            if (response.ResultCode == MqttClientConnectResultCode.Success)
            {
                await Subscribe();
                return true;
            }
            else
            {
                return false;
            }
        }

        void Log(string message, Color textColor)
        {
            var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var logMessage = $"[{timestamp}] {message}\r\n";

            txt_mqtt_message_log.Invoke((MethodInvoker)delegate
            {
                txt_mqtt_message_log.SelectionStart = txt_mqtt_message_log.TextLength;
                txt_mqtt_message_log.SelectionLength = 0;
                txt_mqtt_message_log.SelectionColor = textColor;
                txt_mqtt_message_log.AppendText(logMessage);
                txt_mqtt_message_log.SelectionColor = txt_mqtt_message_log.ForeColor; // Reset color to default
                txt_mqtt_message_log.SelectionStart = txt_mqtt_message_log.Text.Length;
                txt_mqtt_message_log.ScrollToCaret();
            });
        }

        public string RPC_GetStatus()
        {
            return Status.ToString();
        }

        public void RPC_SetStatus(bool value)
        {
            Status = bool.Parse(value.ToString());

            Invoke((MethodInvoker)(delegate
            {
                if (Status)
                {
                    Log("Status: ON", Color.Green);
                    lbl_device_status.Text = "ON";
                    lbl_device_status.ForeColor = Color.Green;
                }
                else
                {
                    Log("Status: OFF", Color.Red);
                    lbl_device_status.Text = "OFF";
                    lbl_device_status.ForeColor = Color.Red;
                }
            }));
        }

        public IMqttClient CreateMqttClient()
        {

            var mqttFactory = new MqttFactory();
            var mqttClient = mqttFactory.CreateMqttClient();
            mqttClient.ApplicationMessageReceivedAsync += async e =>
            {
                var payloadText = string.Empty;
                var topic = e.ApplicationMessage.Topic;
                string requestId = topic.Substring("v1/devices/me/rpc/request/".Length);
                if (e.ApplicationMessage.PayloadSegment.Count > 0)
                {
                    payloadText = Encoding.UTF8.GetString(
                        e.ApplicationMessage.PayloadSegment.Array,
                        e.ApplicationMessage.PayloadSegment.Offset,
                        e.ApplicationMessage.PayloadSegment.Count);
                }

                Console.WriteLine("### RECEIVED APPLICATION MESSAGE ###");
                Console.WriteLine($"+ Topic = {topic}");
                Console.WriteLine($"+ Payload = {payloadText}");
                Console.WriteLine();
                Log(payloadText, Color.Black);

                // RPC
                if (topic.StartsWith(MQTTConfig.Topic_RPC_Request.Replace("+", "")))
                {
                    var rpc = JObject.Parse(payloadText);
                    var method = rpc["method"].ToString();
                    var value = rpc["params"].ToString();
                    var response = "";
                    if (method == "getStatus")
                    {
                        response = RPC_GetStatus();
                    }
                    else if (method == "setStatus")
                    {
                        RPC_SetStatus(bool.Parse(value));
                    }

                    var json = new JObject { { "status", Status } };

                    var responseUrl = MQTTConfig.Topic_RPC_Response + requestId;
                    await Publish(responseUrl, json.ToString());
                }
            };
            return mqttClient;
        }

        public async Task Subscribe()
        {
            var topicFilter1 = new MqttTopicFilterBuilder().WithTopic(MQTTConfig.Topic_Telemetry).Build();
            await mqttClient.SubscribeAsync(topicFilter1);
            Log("Subscribed to " + MQTTConfig.Topic_Telemetry, Color.DarkGreen);

            var topicFilter2 = new MqttTopicFilterBuilder().WithTopic(MQTTConfig.Topic_RPC_Request).Build();
            await mqttClient.SubscribeAsync(topicFilter2);
            Log("Subscribed to " + MQTTConfig.Topic_RPC_Request, Color.DarkGreen);
        }


        public async Task Publish(string topic, string payload)
        {
            if (mqttClient == null)
            {
                MessageBox.Show("Please connect to MQTT first");
            }
            var message = new MqttApplicationMessageBuilder()
                .WithTopic(topic)
                .WithPayload(payload)
                .WithRetainFlag()
                .Build();

            await mqttClient.PublishAsync(message);
        }

        async void SwitchMQTTStatus(bool status)
        {
            if (status)
            {
                if (txt_mqtt_host.Text == "")
                {
                    MessageBox.Show("Please enter a valid MQTT host");
                    return;
                }
                if (await Connect(txt_mqtt_host.Text))
                {
                    btn_start.Enabled = false;
                    btn_stop.Enabled = true;
                }
            }
            else
            {
                await Disconnect();
                btn_start.Enabled = true;
                btn_stop.Enabled = false;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            SwitchMQTTStatus(status: true);
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            SwitchMQTTStatus(status: false);
        }

        private async void btn_send_publish_Click(object sender, EventArgs e)
        {
            if (mqttClient == null || !mqttClient.IsConnected)
            {
                MessageBox.Show("Please connect to MQTT first");
                return;
            }
            if (mqttClient.IsConnected)
            {
                await Publish(txt_mqtt_publish_topic.Text, txt_mqtt_publish_msg.Text);
            }
        }

        private async void btn_upload_recipe_Click(object sender, EventArgs e)
        {
            List<string> recipeList = new List<string>();

            // 循環讀取DataGridView中的資料
            for (int i = 0; i < dgv_recipe_list.Rows.Count; i++)
            {
                DataGridViewRow row = dgv_recipe_list.Rows[i];
                if (row.Cells.Count > 0 && row.Cells[0].Value != null)
                {
                    string recipeName = row.Cells[0].Value.ToString();
                    recipeList.Add(recipeName);
                }
            }

            // 組成JSON格式
            var json = new { recipe_list = recipeList };
            string jsonString = JsonConvert.SerializeObject(json);

            // 發送MQTT
            await Publish(MQTTConfig.Topic_Attributes, jsonString);
            await Publish(MQTTConfig.Topic_Telemetry, jsonString);
        }
    }
}
