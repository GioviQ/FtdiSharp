﻿namespace FtdiSharpDemo;

partial class I2C_BH1750
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
            this.i2cAddressSelector1 = new FtdiSharpDemo.I2cAddressSelector();
            this.deviceSelector1 = new FtdiSharpDemo.DeviceSelector();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.barGraph1 = new FtdiSharpDemo.BarGraph();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // i2cAddressSelector1
            // 
            this.i2cAddressSelector1.Address = ((byte)(72));
            this.i2cAddressSelector1.Location = new System.Drawing.Point(413, 12);
            this.i2cAddressSelector1.Name = "i2cAddressSelector1";
            this.i2cAddressSelector1.Size = new System.Drawing.Size(125, 53);
            this.i2cAddressSelector1.TabIndex = 0;
            // 
            // deviceSelector1
            // 
            this.deviceSelector1.Location = new System.Drawing.Point(12, 12);
            this.deviceSelector1.Name = "deviceSelector1";
            this.deviceSelector1.Size = new System.Drawing.Size(395, 53);
            this.deviceSelector1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 237);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(598, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // barGraph1
            // 
            this.barGraph1.Location = new System.Drawing.Point(41, 96);
            this.barGraph1.Name = "barGraph1";
            this.barGraph1.Size = new System.Drawing.Size(429, 70);
            this.barGraph1.TabIndex = 9;
            // 
            // I2C_BH1750
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 259);
            this.Controls.Add(this.barGraph1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.deviceSelector1);
            this.Controls.Add(this.i2cAddressSelector1);
            this.Name = "I2C_BH1750";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FtdiSharp BH1750 Light Sensor";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private I2cAddressSelector i2cAddressSelector1;
    private DeviceSelector deviceSelector1;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.Timer timer1;
    private BarGraph barGraph1;
}