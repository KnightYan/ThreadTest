﻿namespace ThreadTest
{
    partial class FrmPrincipal
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
            this.btnComecar = new System.Windows.Forms.Button();
            this.txtProgressBar = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnComecar
            // 
            this.btnComecar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComecar.Location = new System.Drawing.Point(0, 0);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(800, 76);
            this.btnComecar.TabIndex = 3;
            this.btnComecar.Text = "Começar";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // txtProgressBar
            // 
            this.txtProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtProgressBar.Location = new System.Drawing.Point(0, 423);
            this.txtProgressBar.Name = "txtProgressBar";
            this.txtProgressBar.Size = new System.Drawing.Size(800, 27);
            this.txtProgressBar.TabIndex = 4;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 76);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(800, 347);
            this.txtLog.TabIndex = 5;
            this.txtLog.Text = "";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtProgressBar);
            this.Controls.Add(this.btnComecar);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComecar;
        private System.Windows.Forms.TextBox txtProgressBar;
        private System.Windows.Forms.RichTextBox txtLog;
    }
}
