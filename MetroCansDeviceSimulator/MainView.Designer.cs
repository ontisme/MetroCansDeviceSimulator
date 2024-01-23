namespace MetroCansDeviceSimulator
{
    partial class MainView
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_device_name = new System.Windows.Forms.TextBox();
            this.txt_mqtt_host = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mqtt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mqtt_publish_msg = new System.Windows.Forms.TextBox();
            this.btn_send_publish = new System.Windows.Forms.Button();
            this.txt_mqtt_message_log = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mqtt_publish_topic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_recipe_list = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_upload_recipe = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_device_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recipe_list)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Name";
            // 
            // txt_device_name
            // 
            this.txt_device_name.Location = new System.Drawing.Point(6, 84);
            this.txt_device_name.Name = "txt_device_name";
            this.txt_device_name.Size = new System.Drawing.Size(100, 22);
            this.txt_device_name.TabIndex = 1;
            // 
            // txt_mqtt_host
            // 
            this.txt_mqtt_host.Location = new System.Drawing.Point(6, 124);
            this.txt_mqtt_host.Name = "txt_mqtt_host";
            this.txt_mqtt_host.Size = new System.Drawing.Size(178, 22);
            this.txt_mqtt_host.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server Host";
            // 
            // txt_mqtt_username
            // 
            this.txt_mqtt_username.Location = new System.Drawing.Point(214, 124);
            this.txt_mqtt_username.Name = "txt_mqtt_username";
            this.txt_mqtt_username.Size = new System.Drawing.Size(178, 22);
            this.txt_mqtt_username.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.Green;
            this.btn_start.Location = new System.Drawing.Point(6, 21);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(178, 46);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.ForeColor = System.Drawing.Color.Red;
            this.btn_stop.Location = new System.Drawing.Point(214, 23);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(178, 46);
            this.btn_stop.TabIndex = 6;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "MQTT Publish Message";
            // 
            // txt_mqtt_publish_msg
            // 
            this.txt_mqtt_publish_msg.Location = new System.Drawing.Point(8, 443);
            this.txt_mqtt_publish_msg.Multiline = true;
            this.txt_mqtt_publish_msg.Name = "txt_mqtt_publish_msg";
            this.txt_mqtt_publish_msg.Size = new System.Drawing.Size(283, 50);
            this.txt_mqtt_publish_msg.TabIndex = 1;
            // 
            // btn_send_publish
            // 
            this.btn_send_publish.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send_publish.ForeColor = System.Drawing.Color.Black;
            this.btn_send_publish.Location = new System.Drawing.Point(291, 443);
            this.btn_send_publish.Name = "btn_send_publish";
            this.btn_send_publish.Size = new System.Drawing.Size(101, 50);
            this.btn_send_publish.TabIndex = 5;
            this.btn_send_publish.Text = "Send";
            this.btn_send_publish.UseVisualStyleBackColor = true;
            this.btn_send_publish.Click += new System.EventHandler(this.btn_send_publish_Click);
            // 
            // txt_mqtt_message_log
            // 
            this.txt_mqtt_message_log.Location = new System.Drawing.Point(15, 273);
            this.txt_mqtt_message_log.Name = "txt_mqtt_message_log";
            this.txt_mqtt_message_log.Size = new System.Drawing.Size(305, 216);
            this.txt_mqtt_message_log.TabIndex = 7;
            this.txt_mqtt_message_log.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "MQTT Reviced Messages";
            // 
            // txt_mqtt_publish_topic
            // 
            this.txt_mqtt_publish_topic.Location = new System.Drawing.Point(8, 403);
            this.txt_mqtt_publish_topic.Name = "txt_mqtt_publish_topic";
            this.txt_mqtt_publish_topic.Size = new System.Drawing.Size(384, 22);
            this.txt_mqtt_publish_topic.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "MQTT Topic";
            // 
            // dgv_recipe_list
            // 
            this.dgv_recipe_list.AllowUserToAddRows = false;
            this.dgv_recipe_list.AllowUserToDeleteRows = false;
            this.dgv_recipe_list.AllowUserToResizeColumns = false;
            this.dgv_recipe_list.AllowUserToResizeRows = false;
            this.dgv_recipe_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_recipe_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgv_recipe_list.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_recipe_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_recipe_list.Location = new System.Drawing.Point(3, 18);
            this.dgv_recipe_list.Name = "dgv_recipe_list";
            this.dgv_recipe_list.RowHeadersVisible = false;
            this.dgv_recipe_list.RowTemplate.Height = 24;
            this.dgv_recipe_list.Size = new System.Drawing.Size(104, 228);
            this.dgv_recipe_list.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Recipe";
            this.Column1.Name = "Column1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecipeToolStripMenuItem,
            this.deleteRecipeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 48);
            // 
            // addRecipeToolStripMenuItem
            // 
            this.addRecipeToolStripMenuItem.Name = "addRecipeToolStripMenuItem";
            this.addRecipeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addRecipeToolStripMenuItem.Text = "Add Recipe";
            // 
            // deleteRecipeToolStripMenuItem
            // 
            this.deleteRecipeToolStripMenuItem.Name = "deleteRecipeToolStripMenuItem";
            this.deleteRecipeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deleteRecipeToolStripMenuItem.Text = "Delete Recipe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_recipe_list);
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 249);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Local Recipe List";
            // 
            // btn_upload_recipe
            // 
            this.btn_upload_recipe.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload_recipe.ForeColor = System.Drawing.Color.Black;
            this.btn_upload_recipe.Location = new System.Drawing.Point(6, 155);
            this.btn_upload_recipe.Name = "btn_upload_recipe";
            this.btn_upload_recipe.Size = new System.Drawing.Size(155, 100);
            this.btn_upload_recipe.TabIndex = 6;
            this.btn_upload_recipe.Text = "Upload Recipe";
            this.btn_upload_recipe.UseVisualStyleBackColor = true;
            this.btn_upload_recipe.Click += new System.EventHandler(this.btn_upload_recipe_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_upload_recipe);
            this.groupBox3.Controls.Add(this.txt_mqtt_username);
            this.groupBox3.Controls.Add(this.txt_device_name);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btn_start);
            this.groupBox3.Controls.Add(this.txt_mqtt_host);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btn_stop);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btn_send_publish);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_mqtt_publish_msg);
            this.groupBox3.Controls.Add(this.txt_mqtt_publish_topic);
            this.groupBox3.Location = new System.Drawing.Point(326, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 501);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MQTT Client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Task Status:";
            // 
            // lbl_device_status
            // 
            this.lbl_device_status.AutoSize = true;
            this.lbl_device_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_device_status.Location = new System.Drawing.Point(194, 6);
            this.lbl_device_status.Name = "lbl_device_status";
            this.lbl_device_status.Size = new System.Drawing.Size(21, 12);
            this.lbl_device_status.TabIndex = 0;
            this.lbl_device_status.Text = "Off";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_device_status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txt_mqtt_message_log);
            this.Controls.Add(this.label5);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MetroCanS Device Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recipe_list)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_device_name;
        private System.Windows.Forms.TextBox txt_mqtt_host;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mqtt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mqtt_publish_msg;
        private System.Windows.Forms.Button btn_send_publish;
        private System.Windows.Forms.RichTextBox txt_mqtt_message_log;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mqtt_publish_topic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_recipe_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_upload_recipe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_device_status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecipeToolStripMenuItem;
    }
}

