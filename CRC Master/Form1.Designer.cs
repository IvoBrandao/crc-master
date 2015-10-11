namespace CRC_Master
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_InputData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_CalculateCRC = new System.Windows.Forms.Button();
            this.textBox_XOR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_CRC16 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_CRC16Modbus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_CRC_CCITT0xFFFF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_CRC_CCITXModem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_CRC16Sick = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_CRCDNP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_CCITTKermit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1_CRC_CCIT0x1D0F = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_CRC32 = new System.Windows.Forms.TextBox();
            this.checkBox_Reverse = new System.Windows.Forms.CheckBox();
            this.checkBox_LSB_First = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byteCheckSumXORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRC16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRC16ModBusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRC16SickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRCCCITXModemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRCCCIT0xFFFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRCCCITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRCCCITTKermitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRCDNPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRC32ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Bytes = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_CRC8 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_InputData
            // 
            this.textBox_InputData.Location = new System.Drawing.Point(16, 47);
            this.textBox_InputData.Multiline = true;
            this.textBox_InputData.Name = "textBox_InputData";
            this.textBox_InputData.Size = new System.Drawing.Size(614, 62);
            this.textBox_InputData.TabIndex = 0;
            this.textBox_InputData.Text = "Input Data in Hex Format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Data";
            // 
            // button_CalculateCRC
            // 
            this.button_CalculateCRC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button_CalculateCRC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button_CalculateCRC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_CalculateCRC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_CalculateCRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CalculateCRC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CalculateCRC.ForeColor = System.Drawing.Color.White;
            this.button_CalculateCRC.Location = new System.Drawing.Point(202, 288);
            this.button_CalculateCRC.Name = "button_CalculateCRC";
            this.button_CalculateCRC.Size = new System.Drawing.Size(238, 34);
            this.button_CalculateCRC.TabIndex = 4;
            this.button_CalculateCRC.Text = "Calculate CRC";
            this.button_CalculateCRC.UseVisualStyleBackColor = false;
            this.button_CalculateCRC.Click += new System.EventHandler(this.button_CalculateCRC_Click);
            // 
            // textBox_XOR
            // 
            this.textBox_XOR.Location = new System.Drawing.Point(493, 221);
            this.textBox_XOR.Name = "textBox_XOR";
            this.textBox_XOR.Size = new System.Drawing.Size(129, 20);
            this.textBox_XOR.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "1 Byte Checksum (XOR)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CRC 16";
            // 
            // textBox_CRC16
            // 
            this.textBox_CRC16.Location = new System.Drawing.Point(15, 221);
            this.textBox_CRC16.Name = "textBox_CRC16";
            this.textBox_CRC16.Size = new System.Drawing.Size(129, 20);
            this.textBox_CRC16.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "CRC 16 (ModBus)";
            // 
            // textBox_CRC16Modbus
            // 
            this.textBox_CRC16Modbus.Location = new System.Drawing.Point(15, 262);
            this.textBox_CRC16Modbus.Name = "textBox_CRC16Modbus";
            this.textBox_CRC16Modbus.Size = new System.Drawing.Size(129, 20);
            this.textBox_CRC16Modbus.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "CRC CCITT (0xFFFF)";
            // 
            // textBox_CRC_CCITT0xFFFF
            // 
            this.textBox_CRC_CCITT0xFFFF.Location = new System.Drawing.Point(170, 262);
            this.textBox_CRC_CCITT0xFFFF.Name = "textBox_CRC_CCITT0xFFFF";
            this.textBox_CRC_CCITT0xFFFF.Size = new System.Drawing.Size(132, 20);
            this.textBox_CRC_CCITT0xFFFF.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "CRC CCITT (XModem)";
            // 
            // textBox_CRC_CCITXModem
            // 
            this.textBox_CRC_CCITXModem.Location = new System.Drawing.Point(170, 221);
            this.textBox_CRC_CCITXModem.Name = "textBox_CRC_CCITXModem";
            this.textBox_CRC_CCITXModem.Size = new System.Drawing.Size(132, 20);
            this.textBox_CRC_CCITXModem.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "CRC 16 (Sick)";
            // 
            // textBox_CRC16Sick
            // 
            this.textBox_CRC16Sick.Location = new System.Drawing.Point(170, 175);
            this.textBox_CRC16Sick.Name = "textBox_CRC16Sick";
            this.textBox_CRC16Sick.Size = new System.Drawing.Size(132, 20);
            this.textBox_CRC16Sick.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "CRC DNP";
            // 
            // textBox_CRCDNP
            // 
            this.textBox_CRCDNP.Location = new System.Drawing.Point(331, 262);
            this.textBox_CRCDNP.Name = "textBox_CRCDNP";
            this.textBox_CRCDNP.Size = new System.Drawing.Size(137, 20);
            this.textBox_CRCDNP.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(328, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "CRC CCITT (Kermit)";
            // 
            // textBox_CCITTKermit
            // 
            this.textBox_CCITTKermit.Location = new System.Drawing.Point(331, 221);
            this.textBox_CCITTKermit.Name = "textBox_CCITTKermit";
            this.textBox_CCITTKermit.Size = new System.Drawing.Size(137, 20);
            this.textBox_CCITTKermit.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(328, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "CRC  CCITT (0x1D0F)";
            // 
            // textBox1_CRC_CCIT0x1D0F
            // 
            this.textBox1_CRC_CCIT0x1D0F.Location = new System.Drawing.Point(331, 175);
            this.textBox1_CRC_CCIT0x1D0F.Name = "textBox1_CRC_CCIT0x1D0F";
            this.textBox1_CRC_CCIT0x1D0F.Size = new System.Drawing.Size(137, 20);
            this.textBox1_CRC_CCIT0x1D0F.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(490, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "CRC 32";
            // 
            // textBox_CRC32
            // 
            this.textBox_CRC32.Location = new System.Drawing.Point(493, 175);
            this.textBox_CRC32.Name = "textBox_CRC32";
            this.textBox_CRC32.Size = new System.Drawing.Size(137, 20);
            this.textBox_CRC32.TabIndex = 24;
            // 
            // checkBox_Reverse
            // 
            this.checkBox_Reverse.AutoSize = true;
            this.checkBox_Reverse.Location = new System.Drawing.Point(17, 115);
            this.checkBox_Reverse.Name = "checkBox_Reverse";
            this.checkBox_Reverse.Size = new System.Drawing.Size(66, 17);
            this.checkBox_Reverse.TabIndex = 26;
            this.checkBox_Reverse.Text = "Reverse";
            this.checkBox_Reverse.UseVisualStyleBackColor = true;
            // 
            // checkBox_LSB_First
            // 
            this.checkBox_LSB_First.AutoSize = true;
            this.checkBox_LSB_First.Location = new System.Drawing.Point(89, 115);
            this.checkBox_LSB_First.Name = "checkBox_LSB_First";
            this.checkBox_LSB_First.Size = new System.Drawing.Size(123, 17);
            this.checkBox_LSB_First.TabIndex = 27;
            this.checkBox_LSB_First.Text = "Result with LSB First";
            this.checkBox_LSB_First.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.Clear_MenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCAlgorithmToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // copyCAlgorithmToolStripMenuItem
            // 
            this.copyCAlgorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byteCheckSumXORToolStripMenuItem,
            this.cRC16ToolStripMenuItem,
            this.cRC16ModBusToolStripMenuItem,
            this.cRC16SickToolStripMenuItem,
            this.cRCCCITXModemToolStripMenuItem,
            this.cRCCCIT0xFFFFToolStripMenuItem,
            this.cRCCCITToolStripMenuItem,
            this.cRCCCITTKermitToolStripMenuItem,
            this.cRCDNPToolStripMenuItem,
            this.cRC32ToolStripMenuItem});
            this.copyCAlgorithmToolStripMenuItem.Name = "copyCAlgorithmToolStripMenuItem";
            this.copyCAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.copyCAlgorithmToolStripMenuItem.Text = "Copy C Algorithm";
            // 
            // byteCheckSumXORToolStripMenuItem
            // 
            this.byteCheckSumXORToolStripMenuItem.Name = "byteCheckSumXORToolStripMenuItem";
            this.byteCheckSumXORToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.byteCheckSumXORToolStripMenuItem.Text = "1 Byte CheckSum (XOR)";
            // 
            // cRC16ToolStripMenuItem
            // 
            this.cRC16ToolStripMenuItem.Name = "cRC16ToolStripMenuItem";
            this.cRC16ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cRC16ToolStripMenuItem.Text = "CRC 16";
            // 
            // cRC16ModBusToolStripMenuItem
            // 
            this.cRC16ModBusToolStripMenuItem.Name = "cRC16ModBusToolStripMenuItem";
            this.cRC16ModBusToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cRC16ModBusToolStripMenuItem.Text = "CRC 16 (ModBus)";
            // 
            // cRC16SickToolStripMenuItem
            // 
            this.cRC16SickToolStripMenuItem.Name = "cRC16SickToolStripMenuItem";
            this.cRC16SickToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cRC16SickToolStripMenuItem.Text = "CRC 16 (Sick)";
            // 
            // cRCCCITXModemToolStripMenuItem
            // 
            this.cRCCCITXModemToolStripMenuItem.Name = "cRCCCITXModemToolStripMenuItem";
            this.cRCCCITXModemToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cRCCCITXModemToolStripMenuItem.Text = "CRC CCITT (XModem)";
            // 
            // cRCCCIT0xFFFFToolStripMenuItem
            // 
            this.cRCCCIT0xFFFFToolStripMenuItem.Name = "cRCCCIT0xFFFFToolStripMenuItem";
            this.cRCCCIT0xFFFFToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cRCCCIT0xFFFFToolStripMenuItem.Text = "CRC CCITT (0xFFFF)";
            // 
            // cRCCCITToolStripMenuItem
            // 
            this.cRCCCITToolStripMenuItem.Name = "cRCCCITToolStripMenuItem";
            this.cRCCCITToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cRCCCITToolStripMenuItem.Text = "CRC CCITT (0x1D0F)";
            // 
            // cRCCCITTKermitToolStripMenuItem
            // 
            this.cRCCCITTKermitToolStripMenuItem.Name = "cRCCCITTKermitToolStripMenuItem";
            this.cRCCCITTKermitToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cRCCCITTKermitToolStripMenuItem.Text = "CRC CCITT (Kermit)";
            // 
            // cRCDNPToolStripMenuItem
            // 
            this.cRCDNPToolStripMenuItem.Name = "cRCDNPToolStripMenuItem";
            this.cRCDNPToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cRCDNPToolStripMenuItem.Text = "CRC DNP";
            // 
            // cRC32ToolStripMenuItem
            // 
            this.cRC32ToolStripMenuItem.Name = "cRC32ToolStripMenuItem";
            this.cRC32ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cRC32ToolStripMenuItem.Text = "CRC 32";
            // 
            // Clear_MenuItem
            // 
            this.Clear_MenuItem.Name = "Clear_MenuItem";
            this.Clear_MenuItem.Size = new System.Drawing.Size(46, 20);
            this.Clear_MenuItem.Text = "Clear";
            this.Clear_MenuItem.Click += new System.EventHandler(this.Clear_MenuItem_Click);
            // 
            // label_Bytes
            // 
            this.label_Bytes.AutoSize = true;
            this.label_Bytes.Location = new System.Drawing.Point(218, 116);
            this.label_Bytes.Name = "label_Bytes";
            this.label_Bytes.Size = new System.Drawing.Size(39, 13);
            this.label_Bytes.TabIndex = 30;
            this.label_Bytes.Text = "Bytes: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "CRC 8";
            // 
            // textBox_CRC8
            // 
            this.textBox_CRC8.Location = new System.Drawing.Point(12, 175);
            this.textBox_CRC8.Name = "textBox_CRC8";
            this.textBox_CRC8.Size = new System.Drawing.Size(129, 20);
            this.textBox_CRC8.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 336);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_CRC8);
            this.Controls.Add(this.label_Bytes);
            this.Controls.Add(this.checkBox_LSB_First);
            this.Controls.Add(this.checkBox_Reverse);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_CRC32);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_CRCDNP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_CCITTKermit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1_CRC_CCIT0x1D0F);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_CRC_CCITT0xFFFF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_CRC_CCITXModem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_CRC16Sick);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_CRC16Modbus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_CRC16);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_XOR);
            this.Controls.Add(this.button_CalculateCRC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_InputData);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(652, 375);
            this.MinimumSize = new System.Drawing.Size(652, 375);
            this.Name = "Form1";
            this.Text = "CRC Master";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_InputData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_CalculateCRC;
        private System.Windows.Forms.TextBox textBox_XOR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_CRC16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_CRC16Modbus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_CRC_CCITT0xFFFF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_CRC_CCITXModem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_CRC16Sick;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_CRCDNP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_CCITTKermit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1_CRC_CCIT0x1D0F;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_CRC32;
        private System.Windows.Forms.CheckBox checkBox_Reverse;
        private System.Windows.Forms.CheckBox checkBox_LSB_First;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCAlgorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byteCheckSumXORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRC16ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRC16ModBusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRC16SickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRCCCITXModemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRCCCIT0xFFFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRCCCITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRCCCITTKermitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRCDNPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRC32ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Clear_MenuItem;
        private System.Windows.Forms.Label label_Bytes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_CRC8;
    }
}

