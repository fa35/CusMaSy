namespace CusMaSy.Project.Views
{
    partial class Shop
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
            this.tbxURLShop = new System.Windows.Forms.Label();
            this.lblShopnameShop = new System.Windows.Forms.Label();
            this.lblIDShop = new System.Windows.Forms.Label();
            this.tbxIDKunde = new System.Windows.Forms.TextBox();
            this.tbxShopnameShop = new System.Windows.Forms.TextBox();
            this.btnSpeichernShop = new System.Windows.Forms.Button();
            this.txbURLShop = new System.Windows.Forms.TextBox();
            this.lblShopinformationenShop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxURLShop
            // 
            this.tbxURLShop.AutoSize = true;
            this.tbxURLShop.Location = new System.Drawing.Point(251, 45);
            this.tbxURLShop.Name = "tbxURLShop";
            this.tbxURLShop.Size = new System.Drawing.Size(29, 13);
            this.tbxURLShop.TabIndex = 26;
            this.tbxURLShop.Text = "URL";
            this.tbxURLShop.Click += new System.EventHandler(this.tbxLandKunde_Click);
            // 
            // lblShopnameShop
            // 
            this.lblShopnameShop.AutoSize = true;
            this.lblShopnameShop.Location = new System.Drawing.Point(131, 45);
            this.lblShopnameShop.Name = "lblShopnameShop";
            this.lblShopnameShop.Size = new System.Drawing.Size(58, 13);
            this.lblShopnameShop.TabIndex = 25;
            this.lblShopnameShop.Text = "Shopname";
            this.lblShopnameShop.Click += new System.EventHandler(this.lblOrtKunde_Click);
            // 
            // lblIDShop
            // 
            this.lblIDShop.AutoSize = true;
            this.lblIDShop.Location = new System.Drawing.Point(28, 45);
            this.lblIDShop.Name = "lblIDShop";
            this.lblIDShop.Size = new System.Drawing.Size(18, 13);
            this.lblIDShop.TabIndex = 24;
            this.lblIDShop.Text = "ID";
            this.lblIDShop.Click += new System.EventHandler(this.lblPLZKunde_Click);
            // 
            // tbxIDKunde
            // 
            this.tbxIDKunde.Location = new System.Drawing.Point(28, 61);
            this.tbxIDKunde.Name = "tbxIDKunde";
            this.tbxIDKunde.Size = new System.Drawing.Size(100, 20);
            this.tbxIDKunde.TabIndex = 19;
            this.tbxIDKunde.TextChanged += new System.EventHandler(this.tbxPLZKunde_TextChanged);
            // 
            // tbxShopnameShop
            // 
            this.tbxShopnameShop.Location = new System.Drawing.Point(134, 61);
            this.tbxShopnameShop.Name = "tbxShopnameShop";
            this.tbxShopnameShop.Size = new System.Drawing.Size(100, 20);
            this.tbxShopnameShop.TabIndex = 18;
            this.tbxShopnameShop.TextChanged += new System.EventHandler(this.tbxOrtKunde_TextChanged);
            // 
            // btnSpeichernShop
            // 
            this.btnSpeichernShop.Location = new System.Drawing.Point(279, 105);
            this.btnSpeichernShop.Name = "btnSpeichernShop";
            this.btnSpeichernShop.Size = new System.Drawing.Size(75, 23);
            this.btnSpeichernShop.TabIndex = 14;
            this.btnSpeichernShop.Text = "Speichern";
            this.btnSpeichernShop.UseVisualStyleBackColor = true;
            this.btnSpeichernShop.Click += new System.EventHandler(this.btnSpeichernKunde_Click);
            // 
            // txbURLShop
            // 
            this.txbURLShop.Location = new System.Drawing.Point(254, 61);
            this.txbURLShop.Name = "txbURLShop";
            this.txbURLShop.Size = new System.Drawing.Size(100, 20);
            this.txbURLShop.TabIndex = 27;
            // 
            // lblShopinformationenShop
            // 
            this.lblShopinformationenShop.AutoSize = true;
            this.lblShopinformationenShop.Location = new System.Drawing.Point(25, 9);
            this.lblShopinformationenShop.Name = "lblShopinformationenShop";
            this.lblShopinformationenShop.Size = new System.Drawing.Size(95, 13);
            this.lblShopinformationenShop.TabIndex = 28;
            this.lblShopinformationenShop.Text = "Shopinformationen";
            this.lblShopinformationenShop.Click += new System.EventHandler(this.label1_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 449);
            this.Controls.Add(this.lblShopinformationenShop);
            this.Controls.Add(this.txbURLShop);
            this.Controls.Add(this.tbxURLShop);
            this.Controls.Add(this.lblShopnameShop);
            this.Controls.Add(this.lblIDShop);
            this.Controls.Add(this.tbxIDKunde);
            this.Controls.Add(this.tbxShopnameShop);
            this.Controls.Add(this.btnSpeichernShop);
            this.Name = "Shop";
            this.Text = "Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tbxURLShop;
        private System.Windows.Forms.Label lblShopnameShop;
        private System.Windows.Forms.Label lblIDShop;
        private System.Windows.Forms.TextBox tbxIDKunde;
        private System.Windows.Forms.TextBox tbxShopnameShop;
        private System.Windows.Forms.Button btnSpeichernShop;
        private System.Windows.Forms.TextBox txbURLShop;
        private System.Windows.Forms.Label lblShopinformationenShop;
    }
}