namespace CusMaSy.Project.Views
{
    partial class Hauptansicht
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
            this.dgvAnbieterDetails = new System.Windows.Forms.DataGridView();
            this.KundenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StraßeHausnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnAddRelation = new System.Windows.Forms.Button();
            this.btnDeleteRelation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAnbieter = new System.Windows.Forms.Button();
            this.btnAddAnbieter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnbieterDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShopUeberblick
            // 
            this.lblShopUeberblick.AutoSize = true;
            this.lblShopUeberblick.Location = new System.Drawing.Point(25, 23);
            this.lblShopUeberblick.Name = "lblShopUeberblick";
            this.lblShopUeberblick.Size = new System.Drawing.Size(46, 13);
            this.lblShopUeberblick.TabIndex = 1;
            this.lblShopUeberblick.Text = "Anbieter";
            // 
            // lblKundenUeberblick
            // 
            this.lblKundenUeberblick.AutoSize = true;
            this.lblKundenUeberblick.Location = new System.Drawing.Point(352, 23);
            this.lblKundenUeberblick.Name = "lblKundenUeberblick";
            this.lblKundenUeberblick.Size = new System.Drawing.Size(59, 13);
            this.lblKundenUeberblick.TabIndex = 3;
            this.lblKundenUeberblick.Text = "Zuordnung";
            // 
            // ltvKundenlisteUeberblick
            // 
            this.ltvKundenlisteUeberblick.Location = new System.Drawing.Point(355, 39);
            this.ltvKundenlisteUeberblick.Name = "ltvKundenlisteUeberblick";
            this.ltvKundenlisteUeberblick.Size = new System.Drawing.Size(215, 153);
            this.ltvKundenlisteUeberblick.TabIndex = 4;
            this.ltvKundenlisteUeberblick.UseCompatibleStateImageBehavior = false;
            // 
            // ltvShoplisteUeberblick
            // 
            this.ltvShoplisteUeberblick.Location = new System.Drawing.Point(28, 39);
            this.ltvShoplisteUeberblick.Name = "ltvShoplisteUeberblick";
            this.ltvShoplisteUeberblick.Size = new System.Drawing.Size(215, 153);
            this.ltvShoplisteUeberblick.TabIndex = 5;
            this.ltvShoplisteUeberblick.UseCompatibleStateImageBehavior = false;
            // 
            // dgvAnbieterDetails
            // 
            this.dgvAnbieterDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnbieterDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KundenID,
            this.Firma,
            this.StraßeHausnummer,
            this.PLZ,
            this.Ort});
            this.dgvAnbieterDetails.Location = new System.Drawing.Point(28, 241);
            this.dgvAnbieterDetails.Name = "dgvAnbieterDetails";
            this.dgvAnbieterDetails.Size = new System.Drawing.Size(542, 216);
            this.dgvAnbieterDetails.TabIndex = 6;
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
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(598, 505);
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
            // btnAddRelation
            // 
            this.btnAddRelation.Location = new System.Drawing.Point(249, 87);
            this.btnAddRelation.Name = "btnAddRelation";
            this.btnAddRelation.Size = new System.Drawing.Size(100, 25);
            this.btnAddRelation.TabIndex = 8;
            this.btnAddRelation.Text = "hinzufügen";
            this.btnAddRelation.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRelation
            // 
            this.btnDeleteRelation.Location = new System.Drawing.Point(249, 118);
            this.btnDeleteRelation.Name = "btnDeleteRelation";
            this.btnDeleteRelation.Size = new System.Drawing.Size(100, 25);
            this.btnDeleteRelation.TabIndex = 9;
            this.btnDeleteRelation.Text = "entfernen";
            this.btnDeleteRelation.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Anbieter - Details";
            // 
            // btnDeleteAnbieter
            // 
            this.btnDeleteAnbieter.Location = new System.Drawing.Point(470, 468);
            this.btnDeleteAnbieter.Name = "btnDeleteAnbieter";
            this.btnDeleteAnbieter.Size = new System.Drawing.Size(100, 25);
            this.btnDeleteAnbieter.TabIndex = 11;
            this.btnDeleteAnbieter.Text = "entfernen";
            this.btnDeleteAnbieter.UseVisualStyleBackColor = true;
            this.btnDeleteAnbieter.Click += new System.EventHandler(this.btnDeleteAnbieter_Click);
            // 
            // btnAddAnbieter
            // 
            this.btnAddAnbieter.Location = new System.Drawing.Point(355, 468);
            this.btnAddAnbieter.Name = "btnAddAnbieter";
            this.btnAddAnbieter.Size = new System.Drawing.Size(100, 25);
            this.btnAddAnbieter.TabIndex = 12;
            this.btnAddAnbieter.Text = "hinzufügen";
            this.btnAddAnbieter.UseVisualStyleBackColor = true;
            this.btnAddAnbieter.Click += new System.EventHandler(this.btnAddAnbieter_Click);
            // 
            // Hauptansicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 505);
            this.Controls.Add(this.btnAddAnbieter);
            this.Controls.Add(this.btnDeleteAnbieter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteRelation);
            this.Controls.Add(this.btnAddRelation);
            this.Controls.Add(this.dgvAnbieterDetails);
            this.Controls.Add(this.ltvShoplisteUeberblick);
            this.Controls.Add(this.ltvKundenlisteUeberblick);
            this.Controls.Add(this.lblKundenUeberblick);
            this.Controls.Add(this.lblShopUeberblick);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Hauptansicht";
            this.Text = "Hauptansicht";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnbieterDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShopUeberblick;
        private System.Windows.Forms.Label lblKundenUeberblick;
        private System.Windows.Forms.ListView ltvKundenlisteUeberblick;
        private System.Windows.Forms.ListView ltvShoplisteUeberblick;
        private System.Windows.Forms.DataGridView dgvAnbieterDetails;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnAddRelation;
        private System.Windows.Forms.Button btnDeleteRelation;
        private System.Windows.Forms.DataGridViewTextBoxColumn KundenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn StraßeHausnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteAnbieter;
        private System.Windows.Forms.Button btnAddAnbieter;
    }
}