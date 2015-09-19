namespace CusMaSy.Project.Views
{
    partial class frmKunde
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
            this.btnSpeichernKunde = new System.Windows.Forms.Button();
            this.tbxNameKunde = new System.Windows.Forms.TextBox();
            this.lblNameKunde = new System.Windows.Forms.Label();
            this.tbxHausnummerKunde = new System.Windows.Forms.TextBox();
            this.tbxOrtKunde = new System.Windows.Forms.TextBox();
            this.tbxPLZKunde = new System.Windows.Forms.TextBox();
            this.tbxStraßeKunde = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblHausnummerKunde = new System.Windows.Forms.Label();
            this.lblStraßeKunde = new System.Windows.Forms.Label();
            this.lblPLZKunde = new System.Windows.Forms.Label();
            this.lblOrtKunde = new System.Windows.Forms.Label();
            this.tbxLandKunde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSpeichernKunde
            // 
            this.btnSpeichernKunde.Location = new System.Drawing.Point(287, 168);
            this.btnSpeichernKunde.Name = "btnSpeichernKunde";
            this.btnSpeichernKunde.Size = new System.Drawing.Size(75, 23);
            this.btnSpeichernKunde.TabIndex = 1;
            this.btnSpeichernKunde.Text = "Speichern";
            this.btnSpeichernKunde.UseVisualStyleBackColor = true;
            this.btnSpeichernKunde.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxNameKunde
            // 
            this.tbxNameKunde.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxNameKunde.Location = new System.Drawing.Point(15, 25);
            this.tbxNameKunde.Name = "tbxNameKunde";
            this.tbxNameKunde.Size = new System.Drawing.Size(100, 20);
            this.tbxNameKunde.TabIndex = 2;
            this.tbxNameKunde.TextChanged += new System.EventHandler(this.tbxNameKunde_TextChanged);
            // 
            // lblNameKunde
            // 
            this.lblNameKunde.AutoSize = true;
            this.lblNameKunde.Location = new System.Drawing.Point(15, 9);
            this.lblNameKunde.Name = "lblNameKunde";
            this.lblNameKunde.Size = new System.Drawing.Size(35, 13);
            this.lblNameKunde.TabIndex = 3;
            this.lblNameKunde.Text = "Name";
            // 
            // tbxHausnummerKunde
            // 
            this.tbxHausnummerKunde.Location = new System.Drawing.Point(121, 73);
            this.tbxHausnummerKunde.Name = "tbxHausnummerKunde";
            this.tbxHausnummerKunde.Size = new System.Drawing.Size(100, 20);
            this.tbxHausnummerKunde.TabIndex = 4;
            // 
            // tbxOrtKunde
            // 
            this.tbxOrtKunde.Location = new System.Drawing.Point(121, 127);
            this.tbxOrtKunde.Name = "tbxOrtKunde";
            this.tbxOrtKunde.Size = new System.Drawing.Size(100, 20);
            this.tbxOrtKunde.TabIndex = 5;
            // 
            // tbxPLZKunde
            // 
            this.tbxPLZKunde.Location = new System.Drawing.Point(15, 126);
            this.tbxPLZKunde.Name = "tbxPLZKunde";
            this.tbxPLZKunde.Size = new System.Drawing.Size(100, 20);
            this.tbxPLZKunde.TabIndex = 6;
            // 
            // tbxStraßeKunde
            // 
            this.tbxStraßeKunde.Location = new System.Drawing.Point(15, 73);
            this.tbxStraßeKunde.Name = "tbxStraßeKunde";
            this.tbxStraßeKunde.Size = new System.Drawing.Size(100, 20);
            this.tbxStraßeKunde.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(241, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // lblHausnummerKunde
            // 
            this.lblHausnummerKunde.AutoSize = true;
            this.lblHausnummerKunde.Location = new System.Drawing.Point(121, 57);
            this.lblHausnummerKunde.Name = "lblHausnummerKunde";
            this.lblHausnummerKunde.Size = new System.Drawing.Size(69, 13);
            this.lblHausnummerKunde.TabIndex = 9;
            this.lblHausnummerKunde.Text = "Hausnummer";
            // 
            // lblStraßeKunde
            // 
            this.lblStraßeKunde.AutoSize = true;
            this.lblStraßeKunde.Location = new System.Drawing.Point(12, 57);
            this.lblStraßeKunde.Name = "lblStraßeKunde";
            this.lblStraßeKunde.Size = new System.Drawing.Size(38, 13);
            this.lblStraßeKunde.TabIndex = 10;
            this.lblStraßeKunde.Text = "Straße";
            this.lblStraßeKunde.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPLZKunde
            // 
            this.lblPLZKunde.AutoSize = true;
            this.lblPLZKunde.Location = new System.Drawing.Point(15, 110);
            this.lblPLZKunde.Name = "lblPLZKunde";
            this.lblPLZKunde.Size = new System.Drawing.Size(27, 13);
            this.lblPLZKunde.TabIndex = 11;
            this.lblPLZKunde.Text = "PLZ";
            // 
            // lblOrtKunde
            // 
            this.lblOrtKunde.AutoSize = true;
            this.lblOrtKunde.Location = new System.Drawing.Point(118, 110);
            this.lblOrtKunde.Name = "lblOrtKunde";
            this.lblOrtKunde.Size = new System.Drawing.Size(21, 13);
            this.lblOrtKunde.TabIndex = 12;
            this.lblOrtKunde.Text = "Ort";
            // 
            // tbxLandKunde
            // 
            this.tbxLandKunde.AutoSize = true;
            this.tbxLandKunde.Location = new System.Drawing.Point(238, 110);
            this.tbxLandKunde.Name = "tbxLandKunde";
            this.tbxLandKunde.Size = new System.Drawing.Size(31, 13);
            this.tbxLandKunde.TabIndex = 13;
            this.tbxLandKunde.Text = "Land";
            // 
            // frmKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 449);
            this.Controls.Add(this.tbxLandKunde);
            this.Controls.Add(this.lblOrtKunde);
            this.Controls.Add(this.lblPLZKunde);
            this.Controls.Add(this.lblStraßeKunde);
            this.Controls.Add(this.lblHausnummerKunde);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbxStraßeKunde);
            this.Controls.Add(this.tbxPLZKunde);
            this.Controls.Add(this.tbxOrtKunde);
            this.Controls.Add(this.tbxHausnummerKunde);
            this.Controls.Add(this.lblNameKunde);
            this.Controls.Add(this.tbxNameKunde);
            this.Controls.Add(this.btnSpeichernKunde);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmKunde";
            this.Text = "Kunde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpeichernKunde;
        private System.Windows.Forms.TextBox tbxNameKunde;
        private System.Windows.Forms.Label lblNameKunde;
        private System.Windows.Forms.TextBox tbxHausnummerKunde;
        private System.Windows.Forms.TextBox tbxOrtKunde;
        private System.Windows.Forms.TextBox tbxPLZKunde;
        private System.Windows.Forms.TextBox tbxStraßeKunde;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblHausnummerKunde;
        private System.Windows.Forms.Label lblStraßeKunde;
        private System.Windows.Forms.Label lblPLZKunde;
        private System.Windows.Forms.Label lblOrtKunde;
        private System.Windows.Forms.Label tbxLandKunde;
    }
}