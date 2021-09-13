
using GMap.NET.WindowsForms;

namespace RobotNav
{
    partial class SendSMS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ModemCombo = new System.Windows.Forms.ComboBox();
            this.label0 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RobotCombo = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModemCombo
            // 
            this.ModemCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModemCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ModemCombo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModemCombo.FormattingEnabled = true;
            this.ModemCombo.Location = new System.Drawing.Point(12, 37);
            this.ModemCombo.Name = "ModemCombo";
            this.ModemCombo.Size = new System.Drawing.Size(343, 33);
            this.ModemCombo.TabIndex = 0;
            // 
            // label0
            // 
            this.label0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label0.Location = new System.Drawing.Point(122, 9);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(132, 25);
            this.label0.TabIndex = 3;
            this.label0.Text = "Select Modem";
            this.label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SendButton.Location = new System.Drawing.Point(122, 111);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(132, 33);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select robot";
            // 
            // RobotCombo
            // 
            this.RobotCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RobotCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RobotCombo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RobotCombo.FormattingEnabled = true;
            this.RobotCombo.Location = new System.Drawing.Point(131, 72);
            this.RobotCombo.Name = "RobotCombo";
            this.RobotCombo.Size = new System.Drawing.Size(181, 33);
            this.RobotCombo.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddButton.Location = new System.Drawing.Point(318, 72);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(37, 37);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "...";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddClick);
            // 
            // SendSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 147);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RobotCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.ModemCombo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SendSMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ModemCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ComboBox RobotCombo;
        private System.Windows.Forms.Button AddButton;
    }
}

