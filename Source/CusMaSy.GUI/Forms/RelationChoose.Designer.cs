namespace CusMaSy.GUI.Forms
{
    partial class RelationChoose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelationChoose));
            this.lstVAnbieters = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRelations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVAnbieters
            // 
            this.lstVAnbieters.Location = new System.Drawing.Point(21, 39);
            this.lstVAnbieters.Name = "lstVAnbieters";
            this.lstVAnbieters.Size = new System.Drawing.Size(215, 179);
            this.lstVAnbieters.TabIndex = 0;
            this.lstVAnbieters.UseCompatibleStateImageBehavior = false;
            this.lstVAnbieters.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Auswählen:";
            // 
            // btnAddRelations
            // 
            this.btnAddRelations.Location = new System.Drawing.Point(21, 224);
            this.btnAddRelations.Name = "btnAddRelations";
            this.btnAddRelations.Size = new System.Drawing.Size(215, 25);
            this.btnAddRelations.TabIndex = 2;
            this.btnAddRelations.Text = "ausgewählte hinzufügen";
            this.btnAddRelations.UseVisualStyleBackColor = true;
            this.btnAddRelations.Click += new System.EventHandler(this.btnAddRelations_Click);
            // 
            // RelationChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 261);
            this.Controls.Add(this.btnAddRelations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstVAnbieters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelationChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelationChoose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstVAnbieters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRelations;
    }
}