namespace CusMaSy.Project.Views
{
    partial class frmUeberblick
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
            this.lblShopUeberblick = new System.Windows.Forms.Label();
            this.lblKundenUeberblick = new System.Windows.Forms.Label();
            this.ltvKundenlisteUeberblick = new System.Windows.Forms.ListView();
            this.ltvShoplisteUeberblick = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnAddUeberblick = new System.Windows.Forms.Button();
            this.btnDeleteUeberblick = new System.Windows.Forms.Button();
            this.KundenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StraßeHausnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShopUeberblick
            // 
            this.lblShopUeberblick.AutoSize = true;
            this.lblShopUeberblick.Location = new System.Drawing.Point(99, 39);
            this.lblShopUeberblick.Name = "lblShopUeberblick";
            this.lblShopUeberblick.Size = new System.Drawing.Size(32, 13);
            this.lblShopUeberblick.TabIndex = 1;
            this.lblShopUeberblick.Text = "Shop";
            this.lblShopUeberblick.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKundenUeberblick
            // 
            this.lblKundenUeberblick.AutoSize = true;
            this.lblKundenUeberblick.Location = new System.Drawing.Point(510, 39);
            this.lblKundenUeberblick.Name = "lblKundenUeberblick";
            this.lblKundenUeberblick.Size = new System.Drawing.Size(44, 13);
            this.lblKundenUeberblick.TabIndex = 3;
            this.lblKundenUeberblick.Text = "Kunden";
            // 
            // ltvKundenlisteUeberblick
            // 
            this.ltvKundenlisteUeberblick.Location = new System.Drawing.Point(513, 69);
            this.ltvKundenlisteUeberblick.Name = "ltvKundenlisteUeberblick";
            this.ltvKundenlisteUeberblick.Size = new System.Drawing.Size(129, 120);
            this.ltvKundenlisteUeberblick.TabIndex = 4;
            this.ltvKundenlisteUeberblick.UseCompatibleStateImageBehavior = false;
            // 
            // ltvShoplisteUeberblick
            // 
            this.ltvShoplisteUeberblick.Location = new System.Drawing.Point(102, 69);
            this.ltvShoplisteUeberblick.Name = "ltvShoplisteUeberblick";
            this.ltvShoplisteUeberblick.Size = new System.Drawing.Size(129, 120);
            this.ltvShoplisteUeberblick.TabIndex = 5;
            this.ltvShoplisteUeberblick.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KundenID,
            this.Firma,
            this.StraßeHausnummer,
            this.PLZ,
            this.Ort});
            this.dataGridView1.Location = new System.Drawing.Point(102, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 196);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(766, 449);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 104;
            this.lineShape1.X2 = 640;
            this.lineShape1.Y1 = 204;
            this.lineShape1.Y2 = 205;
            // 
            // btnAddUeberblick
            // 
            this.btnAddUeberblick.Location = new System.Drawing.Point(102, 212);
            this.btnAddUeberblick.Name = "btnAddUeberblick";
            this.btnAddUeberblick.Size = new System.Drawing.Size(75, 23);
            this.btnAddUeberblick.TabIndex = 8;
            this.btnAddUeberblick.Text = "Add";
            this.btnAddUeberblick.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUeberblick
            // 
            this.btnDeleteUeberblick.Location = new System.Drawing.Point(183, 212);
            this.btnDeleteUeberblick.Name = "btnDeleteUeberblick";
            this.btnDeleteUeberblick.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUeberblick.TabIndex = 9;
            this.btnDeleteUeberblick.Text = "Delete";
            this.btnDeleteUeberblick.UseVisualStyleBackColor = true;
            // 
            // KundenID
            // 
            this.KundenID.HeaderText = "KundenID";
            this.KundenID.Name = "KundenID";
            // 
            // Firma
            // 
            this.Firma.HeaderText = "Firma";
            this.Firma.Name = "Firma";
            // 
            // StraßeHausnummer
            // 
            this.StraßeHausnummer.HeaderText = "StraßeHausnummer";
            this.StraßeHausnummer.Name = "StraßeHausnummer";
            // 
            // PLZ
            // 
            this.PLZ.HeaderText = "PLZ";
            this.PLZ.Name = "PLZ";
            // 
            // Ort
            // 
            this.Ort.HeaderText = "Ort";
            this.Ort.Name = "Ort";
            // 
            // frmUeberblick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 449);
            this.Controls.Add(this.btnDeleteUeberblick);
            this.Controls.Add(this.btnAddUeberblick);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ltvShoplisteUeberblick);
            this.Controls.Add(this.ltvKundenlisteUeberblick);
            this.Controls.Add(this.lblKundenUeberblick);
            this.Controls.Add(this.lblShopUeberblick);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "frmUeberblick";
            this.Text = "Ueberblick";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShopUeberblick;
        private System.Windows.Forms.Label lblKundenUeberblick;
        private System.Windows.Forms.ListView ltvKundenlisteUeberblick;
        private System.Windows.Forms.ListView ltvShoplisteUeberblick;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnAddUeberblick;
        private System.Windows.Forms.Button btnDeleteUeberblick;
        private System.Windows.Forms.DataGridViewTextBoxColumn KundenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn StraßeHausnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ort;
    }
}