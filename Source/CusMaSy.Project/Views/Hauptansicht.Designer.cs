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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hauptansicht));
            this.lblShopUeberblick = new System.Windows.Forms.Label();
            this.lblKundenUeberblick = new System.Windows.Forms.Label();
            this.lstvRelations = new System.Windows.Forms.ListView();
            this.lstvAnbieter = new System.Windows.Forms.ListView();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnAddRelation = new System.Windows.Forms.Button();
            this.btnDeleteRelation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAnbieter = new System.Windows.Forms.Button();
            this.btnAddAnbieter = new System.Windows.Forms.Button();
            this.dgvAnbieterDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnbieterDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShopUeberblick
            // 
            this.lblShopUeberblick.AutoSize = true;
            this.lblShopUeberblick.Location = new System.Drawing.Point(212, 19);
            this.lblShopUeberblick.Name = "lblShopUeberblick";
            this.lblShopUeberblick.Size = new System.Drawing.Size(46, 13);
            this.lblShopUeberblick.TabIndex = 1;
            this.lblShopUeberblick.Text = "Anbieter";
            // 
            // lblKundenUeberblick
            // 
            this.lblKundenUeberblick.AutoSize = true;
            this.lblKundenUeberblick.Location = new System.Drawing.Point(539, 19);
            this.lblKundenUeberblick.Name = "lblKundenUeberblick";
            this.lblKundenUeberblick.Size = new System.Drawing.Size(59, 13);
            this.lblKundenUeberblick.TabIndex = 3;
            this.lblKundenUeberblick.Text = "Zuordnung";
            // 
            // lstvRelations
            // 
            this.lstvRelations.Location = new System.Drawing.Point(542, 35);
            this.lstvRelations.Name = "lstvRelations";
            this.lstvRelations.Size = new System.Drawing.Size(215, 179);
            this.lstvRelations.TabIndex = 4;
            this.lstvRelations.UseCompatibleStateImageBehavior = false;
            this.lstvRelations.View = System.Windows.Forms.View.List;
            // 
            // lstvAnbieter
            // 
            this.lstvAnbieter.Location = new System.Drawing.Point(215, 35);
            this.lstvAnbieter.MultiSelect = false;
            this.lstvAnbieter.Name = "lstvAnbieter";
            this.lstvAnbieter.Size = new System.Drawing.Size(215, 179);
            this.lstvAnbieter.TabIndex = 5;
            this.lstvAnbieter.UseCompatibleStateImageBehavior = false;
            this.lstvAnbieter.View = System.Windows.Forms.View.List;
            this.lstvAnbieter.VirtualListSize = 50;
            this.lstvAnbieter.SelectedIndexChanged += new System.EventHandler(this.lstvAnbieter_SelectedIndexChanged);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(784, 427);
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
            this.btnAddRelation.Location = new System.Drawing.Point(436, 84);
            this.btnAddRelation.Name = "btnAddRelation";
            this.btnAddRelation.Size = new System.Drawing.Size(100, 25);
            this.btnAddRelation.TabIndex = 8;
            this.btnAddRelation.Text = "hinzufügen";
            this.btnAddRelation.UseVisualStyleBackColor = true;
            this.btnAddRelation.Click += new System.EventHandler(this.btnAddRelation_Click);
            // 
            // btnDeleteRelation
            // 
            this.btnDeleteRelation.Location = new System.Drawing.Point(436, 115);
            this.btnDeleteRelation.Name = "btnDeleteRelation";
            this.btnDeleteRelation.Size = new System.Drawing.Size(100, 25);
            this.btnDeleteRelation.TabIndex = 9;
            this.btnDeleteRelation.Text = "entfernen";
            this.btnDeleteRelation.UseVisualStyleBackColor = true;
            this.btnDeleteRelation.Click += new System.EventHandler(this.btnDeleteRelation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Anbieter - Details";
            // 
            // btnDeleteAnbieter
            // 
            this.btnDeleteAnbieter.Location = new System.Drawing.Point(215, 220);
            this.btnDeleteAnbieter.Name = "btnDeleteAnbieter";
            this.btnDeleteAnbieter.Size = new System.Drawing.Size(215, 25);
            this.btnDeleteAnbieter.TabIndex = 11;
            this.btnDeleteAnbieter.Text = "Anbieter entfernen";
            this.btnDeleteAnbieter.UseVisualStyleBackColor = true;
            this.btnDeleteAnbieter.Click += new System.EventHandler(this.btnDeleteAnbieter_Click);
            // 
            // btnAddAnbieter
            // 
            this.btnAddAnbieter.Location = new System.Drawing.Point(542, 396);
            this.btnAddAnbieter.Name = "btnAddAnbieter";
            this.btnAddAnbieter.Size = new System.Drawing.Size(215, 25);
            this.btnAddAnbieter.TabIndex = 12;
            this.btnAddAnbieter.Text = "Anbieter hinzufügen";
            this.btnAddAnbieter.UseVisualStyleBackColor = true;
            this.btnAddAnbieter.Click += new System.EventHandler(this.btnAddAnbieter_Click);
            // 
            // dgvAnbieterDetails
            // 
            this.dgvAnbieterDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnbieterDetails.Location = new System.Drawing.Point(28, 305);
            this.dgvAnbieterDetails.Name = "dgvAnbieterDetails";
            this.dgvAnbieterDetails.Size = new System.Drawing.Size(729, 85);
            this.dgvAnbieterDetails.TabIndex = 13;
            // 
            // Hauptansicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 427);
            this.Controls.Add(this.dgvAnbieterDetails);
            this.Controls.Add(this.btnAddAnbieter);
            this.Controls.Add(this.btnDeleteAnbieter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteRelation);
            this.Controls.Add(this.btnAddRelation);
            this.Controls.Add(this.lstvAnbieter);
            this.Controls.Add(this.lstvRelations);
            this.Controls.Add(this.lblKundenUeberblick);
            this.Controls.Add(this.lblShopUeberblick);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hauptansicht";
            this.Text = "Hauptansicht";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnbieterDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShopUeberblick;
        private System.Windows.Forms.Label lblKundenUeberblick;
        private System.Windows.Forms.ListView lstvRelations;
        private System.Windows.Forms.ListView lstvAnbieter;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnAddRelation;
        private System.Windows.Forms.Button btnDeleteRelation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteAnbieter;
        private System.Windows.Forms.Button btnAddAnbieter;
        private System.Windows.Forms.DataGridView dgvAnbieterDetails;
    }
}