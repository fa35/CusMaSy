﻿namespace CusMaSy.GUI.Forms
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
            this.lblRelationsText = new System.Windows.Forms.Label();
            this.lstvRelations = new System.Windows.Forms.ListView();
            this.lstvAnbieter = new System.Windows.Forms.ListView();
            this.btnAddRelation = new System.Windows.Forms.Button();
            this.btnDeleteRelation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAnbieter = new System.Windows.Forms.Button();
            this.btnAddAnbieter = new System.Windows.Forms.Button();
            this.dgvAnbieterDetails = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSearchAnbieter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnbieterDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShopUeberblick
            // 
            this.lblShopUeberblick.AutoSize = true;
            this.lblShopUeberblick.Location = new System.Drawing.Point(25, 169);
            this.lblShopUeberblick.Name = "lblShopUeberblick";
            this.lblShopUeberblick.Size = new System.Drawing.Size(66, 13);
            this.lblShopUeberblick.TabIndex = 1;
            this.lblShopUeberblick.Text = "Alle Anbieter";
            // 
            // lblRelationsText
            // 
            this.lblRelationsText.AutoSize = true;
            this.lblRelationsText.Location = new System.Drawing.Point(336, 169);
            this.lblRelationsText.Name = "lblRelationsText";
            this.lblRelationsText.Size = new System.Drawing.Size(59, 13);
            this.lblRelationsText.TabIndex = 3;
            this.lblRelationsText.Text = "Zuordnung";
            // 
            // lstvRelations
            // 
            this.lstvRelations.Location = new System.Drawing.Point(339, 185);
            this.lstvRelations.Name = "lstvRelations";
            this.lstvRelations.Size = new System.Drawing.Size(263, 134);
            this.lstvRelations.TabIndex = 4;
            this.lstvRelations.UseCompatibleStateImageBehavior = false;
            this.lstvRelations.View = System.Windows.Forms.View.List;
            // 
            // lstvAnbieter
            // 
            this.lstvAnbieter.Location = new System.Drawing.Point(28, 185);
            this.lstvAnbieter.MultiSelect = false;
            this.lstvAnbieter.Name = "lstvAnbieter";
            this.lstvAnbieter.Size = new System.Drawing.Size(263, 134);
            this.lstvAnbieter.TabIndex = 5;
            this.lstvAnbieter.UseCompatibleStateImageBehavior = false;
            this.lstvAnbieter.View = System.Windows.Forms.View.List;
            this.lstvAnbieter.VirtualListSize = 50;
            this.lstvAnbieter.SelectedIndexChanged += new System.EventHandler(this.lstvAnbieter_SelectedIndexChanged);
            // 
            // btnAddRelation
            // 
            this.btnAddRelation.Location = new System.Drawing.Point(339, 325);
            this.btnAddRelation.Name = "btnAddRelation";
            this.btnAddRelation.Size = new System.Drawing.Size(263, 25);
            this.btnAddRelation.TabIndex = 8;
            this.btnAddRelation.Text = "Zuordnung /-en hinzufügen";
            this.btnAddRelation.UseVisualStyleBackColor = true;
            this.btnAddRelation.Click += new System.EventHandler(this.btnAddRelation_Click);
            // 
            // btnDeleteRelation
            // 
            this.btnDeleteRelation.Location = new System.Drawing.Point(339, 356);
            this.btnDeleteRelation.Name = "btnDeleteRelation";
            this.btnDeleteRelation.Size = new System.Drawing.Size(263, 25);
            this.btnDeleteRelation.TabIndex = 9;
            this.btnDeleteRelation.Text = "Zuordnung /-en entfernen";
            this.btnDeleteRelation.UseVisualStyleBackColor = true;
            this.btnDeleteRelation.Click += new System.EventHandler(this.btnDeleteRelation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bearbeitung der Anbieter-Details";
            // 
            // btnDeleteAnbieter
            // 
            this.btnDeleteAnbieter.Location = new System.Drawing.Point(28, 356);
            this.btnDeleteAnbieter.Name = "btnDeleteAnbieter";
            this.btnDeleteAnbieter.Size = new System.Drawing.Size(263, 25);
            this.btnDeleteAnbieter.TabIndex = 11;
            this.btnDeleteAnbieter.Text = "Anbieter entfernen";
            this.btnDeleteAnbieter.UseVisualStyleBackColor = true;
            this.btnDeleteAnbieter.Click += new System.EventHandler(this.btnDeleteAnbieter_Click);
            // 
            // btnAddAnbieter
            // 
            this.btnAddAnbieter.Location = new System.Drawing.Point(28, 325);
            this.btnAddAnbieter.Name = "btnAddAnbieter";
            this.btnAddAnbieter.Size = new System.Drawing.Size(263, 25);
            this.btnAddAnbieter.TabIndex = 12;
            this.btnAddAnbieter.Text = "Anbieter hinzufügen";
            this.btnAddAnbieter.UseVisualStyleBackColor = true;
            this.btnAddAnbieter.Click += new System.EventHandler(this.btnAddAnbieter_Click);
            // 
            // dgvAnbieterDetails
            // 
            this.dgvAnbieterDetails.AllowUserToAddRows = false;
            this.dgvAnbieterDetails.AllowUserToDeleteRows = false;
            this.dgvAnbieterDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnbieterDetails.Location = new System.Drawing.Point(28, 68);
            this.dgvAnbieterDetails.Name = "dgvAnbieterDetails";
            this.dgvAnbieterDetails.Size = new System.Drawing.Size(574, 85);
            this.dgvAnbieterDetails.TabIndex = 13;
            this.dgvAnbieterDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnbieterDetails_CellEndEdit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nach Anbieter suchen - Name oder Nummer eingeben:";
            // 
            // txbSearchAnbieter
            // 
            this.txbSearchAnbieter.Location = new System.Drawing.Point(339, 16);
            this.txbSearchAnbieter.Name = "txbSearchAnbieter";
            this.txbSearchAnbieter.Size = new System.Drawing.Size(263, 20);
            this.txbSearchAnbieter.TabIndex = 16;
            this.txbSearchAnbieter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearchAnbieter_KeyDown);
            // 
            // Hauptansicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 405);
            this.Controls.Add(this.txbSearchAnbieter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAnbieterDetails);
            this.Controls.Add(this.btnAddAnbieter);
            this.Controls.Add(this.btnDeleteAnbieter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteRelation);
            this.Controls.Add(this.btnAddRelation);
            this.Controls.Add(this.lstvAnbieter);
            this.Controls.Add(this.lstvRelations);
            this.Controls.Add(this.lblRelationsText);
            this.Controls.Add(this.lblShopUeberblick);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hauptansicht";
            this.Text = "Hauptansicht";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnbieterDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShopUeberblick;
        private System.Windows.Forms.Label lblRelationsText;
        private System.Windows.Forms.ListView lstvRelations;
        private System.Windows.Forms.ListView lstvAnbieter;
        private System.Windows.Forms.Button btnAddRelation;
        private System.Windows.Forms.Button btnDeleteRelation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteAnbieter;
        private System.Windows.Forms.Button btnAddAnbieter;
        private System.Windows.Forms.DataGridView dgvAnbieterDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSearchAnbieter;


    }
}