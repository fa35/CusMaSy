﻿namespace CusMaSy.GUI.Forms
{
    partial class AddState
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddState));
            this.btnAddState = new System.Windows.Forms.Button();
            this.txbState = new System.Windows.Forms.TextBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddState
            // 
            this.btnAddState.Enabled = false;
            this.btnAddState.Location = new System.Drawing.Point(160, 38);
            this.btnAddState.Name = "btnAddState";
            this.btnAddState.Size = new System.Drawing.Size(100, 25);
            this.btnAddState.TabIndex = 0;
            this.btnAddState.Text = "hinzufügen";
            this.btnAddState.UseVisualStyleBackColor = true;
            this.btnAddState.Click += new System.EventHandler(this.btnAddState_Click);
            // 
            // txbState
            // 
            this.txbState.Location = new System.Drawing.Point(12, 12);
            this.txbState.Name = "txbState";
            this.txbState.Size = new System.Drawing.Size(248, 20);
            this.txbState.TabIndex = 1;
            this.txbState.TextChanged += new System.EventHandler(this.txbState_TextChanged);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(12, 43);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 13);
            this.lblWarning.TabIndex = 2;
            this.lblWarning.Visible = false;
            // 
            // AddState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 70);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.txbState);
            this.Controls.Add(this.btnAddState);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddState";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddState;
        private System.Windows.Forms.TextBox txbState;
        private System.Windows.Forms.Label lblWarning;
    }
}