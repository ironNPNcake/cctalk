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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 261);
            this.Controls.Add(this.closePortButton);
            this.Controls.Add(this.openPortButton);
            this.Controls.Add(this.comPortList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comPortList;
        private System.Windows.Forms.Button openPortButton;
        private System.Windows.Forms.Button closePortButton;
    }
}

