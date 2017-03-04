namespace cctalk
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comPortList = new System.Windows.Forms.ComboBox();
            this.openPortButton = new System.Windows.Forms.Button();
            this.closePortButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radioButtonAscii = new System.Windows.Forms.RadioButton();
            this.radioButtonHex = new System.Windows.Forms.RadioButton();
            this.textBoxToSend = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.checkBox0X = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxFormat = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comPortList
            // 
            this.comPortList.FormattingEnabled = true;
            this.comPortList.Items.AddRange(new object[] {
            "(Scan...)"});
            this.comPortList.Location = new System.Drawing.Point(12, 12);
            this.comPortList.Name = "comPortList";
            this.comPortList.Size = new System.Drawing.Size(121, 21);
            this.comPortList.TabIndex = 0;
            this.comPortList.SelectedIndexChanged += new System.EventHandler(this.comPortList_SelectedIndexChanged);
            // 
            // openPortButton
            // 
            this.openPortButton.Location = new System.Drawing.Point(139, 9);
            this.openPortButton.Name = "openPortButton";
            this.openPortButton.Size = new System.Drawing.Size(75, 23);
            this.openPortButton.TabIndex = 1;
            this.openPortButton.Text = "&Open";
            this.openPortButton.UseVisualStyleBackColor = true;
            this.openPortButton.Click += new System.EventHandler(this.openPortButton_Click);
            // 
            // closePortButton
            // 
            this.closePortButton.Location = new System.Drawing.Point(220, 9);
            this.closePortButton.Name = "closePortButton";
            this.closePortButton.Size = new System.Drawing.Size(75, 23);
            this.closePortButton.TabIndex = 2;
            this.closePortButton.Text = "&Close";
            this.closePortButton.UseVisualStyleBackColor = true;
            this.closePortButton.Click += new System.EventHandler(this.closePortButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(12, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(628, 423);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // radioButtonAscii
            // 
            this.radioButtonAscii.AutoSize = true;
            this.radioButtonAscii.Location = new System.Drawing.Point(319, 12);
            this.radioButtonAscii.Name = "radioButtonAscii";
            this.radioButtonAscii.Size = new System.Drawing.Size(52, 17);
            this.radioButtonAscii.TabIndex = 4;
            this.radioButtonAscii.Text = "ASCII";
            this.radioButtonAscii.UseVisualStyleBackColor = true;
            // 
            // radioButtonHex
            // 
            this.radioButtonHex.AutoSize = true;
            this.radioButtonHex.Checked = true;
            this.radioButtonHex.Location = new System.Drawing.Point(377, 12);
            this.radioButtonHex.Name = "radioButtonHex";
            this.radioButtonHex.Size = new System.Drawing.Size(47, 17);
            this.radioButtonHex.TabIndex = 5;
            this.radioButtonHex.TabStop = true;
            this.radioButtonHex.Text = "HEX";
            this.radioButtonHex.UseVisualStyleBackColor = true;
            // 
            // textBoxToSend
            // 
            this.textBoxToSend.HideSelection = false;
            this.textBoxToSend.Location = new System.Drawing.Point(12, 468);
            this.textBoxToSend.Name = "textBoxToSend";
            this.textBoxToSend.Size = new System.Drawing.Size(657, 20);
            this.textBoxToSend.TabIndex = 6;
            this.textBoxToSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxToSend_KeyDown);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(675, 468);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // checkBox0X
            // 
            this.checkBox0X.AutoSize = true;
            this.checkBox0X.Location = new System.Drawing.Point(430, 12);
            this.checkBox0X.Name = "checkBox0X";
            this.checkBox0X.Size = new System.Drawing.Size(73, 17);
            this.checkBox0X.TabIndex = 8;
            this.checkBox0X.Text = "Enable 0x";
            this.checkBox0X.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 505);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(677, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(695, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Value: 0";
            // 
            // checkBoxFormat
            // 
            this.checkBoxFormat.AutoSize = true;
            this.checkBoxFormat.Location = new System.Drawing.Point(22, 547);
            this.checkBoxFormat.Name = "checkBoxFormat";
            this.checkBoxFormat.Size = new System.Drawing.Size(103, 17);
            this.checkBoxFormat.TabIndex = 11;
            this.checkBoxFormat.Text = "Format Manually";
            this.checkBoxFormat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 576);
            this.Controls.Add(this.checkBoxFormat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.checkBox0X);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.textBoxToSend);
            this.Controls.Add(this.radioButtonHex);
            this.Controls.Add(this.radioButtonAscii);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.closePortButton);
            this.Controls.Add(this.openPortButton);
            this.Controls.Add(this.comPortList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comPortList;
        private System.Windows.Forms.Button openPortButton;
        private System.Windows.Forms.Button closePortButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radioButtonAscii;
        private System.Windows.Forms.RadioButton radioButtonHex;
        private System.Windows.Forms.TextBox textBoxToSend;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.CheckBox checkBox0X;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxFormat;
    }
}

