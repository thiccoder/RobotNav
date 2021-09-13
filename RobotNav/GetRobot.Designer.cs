
using GMap.NET.WindowsForms;

namespace RobotNav
{
    partial class GetRobot
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
           this.Submit = new System.Windows.Forms.Button();
            this.PhoneNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.Label = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Submit.Location = new System.Drawing.Point(12, 72);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(88, 33);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.SubmitClick);
            // 
            // PhoneNumberUpDown
            // 
            this.PhoneNumberUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumberUpDown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberUpDown.Location = new System.Drawing.Point(41, 37);
            this.PhoneNumberUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.PhoneNumberUpDown.Name = "PhoneNumberUpDown";
            this.PhoneNumberUpDown.Size = new System.Drawing.Size(156, 29);
            this.PhoneNumberUpDown.TabIndex = 1;
            this.PhoneNumberUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(12, 9);
            this.Label.Name = "label";
            this.Label.Size = new System.Drawing.Size(242, 25);
            this.Label.TabIndex = 4;
            this.Label.Text = "Enter robot phone number ";
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancel.Location = new System.Drawing.Point(148, 72);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 33);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.CancelClick);
            // 
            // GetRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 106);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.PhoneNumberUpDown);
            this.Controls.Add(this.Submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GetRobot";
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.NumericUpDown PhoneNumberUpDown;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button Cancel;
    }
}

