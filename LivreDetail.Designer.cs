namespace GestionDesLivres
{
    partial class LivreDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titreData = new System.Windows.Forms.Label();
            this.genreData = new System.Windows.Forms.Label();
            this.dateData = new System.Windows.Forms.Label();
            this.auteurData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Auteur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Publciation";
            // 
            // titreData
            // 
            this.titreData.AutoSize = true;
            this.titreData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreData.Location = new System.Drawing.Point(271, 96);
            this.titreData.Name = "titreData";
            this.titreData.Size = new System.Drawing.Size(64, 25);
            this.titreData.TabIndex = 4;
            this.titreData.Text = "label1";
            // 
            // genreData
            // 
            this.genreData.AutoSize = true;
            this.genreData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreData.Location = new System.Drawing.Point(271, 205);
            this.genreData.Name = "genreData";
            this.genreData.Size = new System.Drawing.Size(64, 25);
            this.genreData.TabIndex = 5;
            this.genreData.Text = "label3";
            // 
            // dateData
            // 
            this.dateData.AutoSize = true;
            this.dateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateData.Location = new System.Drawing.Point(271, 261);
            this.dateData.Name = "dateData";
            this.dateData.Size = new System.Drawing.Size(64, 25);
            this.dateData.TabIndex = 6;
            this.dateData.Text = "label4";
            // 
            // auteurData
            // 
            this.auteurData.AutoSize = true;
            this.auteurData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auteurData.Location = new System.Drawing.Point(271, 150);
            this.auteurData.Name = "auteurData";
            this.auteurData.Size = new System.Drawing.Size(64, 25);
            this.auteurData.TabIndex = 7;
            this.auteurData.Text = "label2";
            // 
            // LivreDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 384);
            this.Controls.Add(this.auteurData);
            this.Controls.Add(this.dateData);
            this.Controls.Add(this.genreData);
            this.Controls.Add(this.titreData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LivreDetail";
            this.Load += new System.EventHandler(this.AjoutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAjouterLivre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label titreData;
        private System.Windows.Forms.Label genreData;
        private System.Windows.Forms.Label dateData;
        private System.Windows.Forms.Label auteurData;
    }
}