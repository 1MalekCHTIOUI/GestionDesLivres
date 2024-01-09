namespace GestionDesLivres
{
    partial class Form1
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
            this.btnChar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.BooksDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.datePub = new System.Windows.Forms.TextBox();
            this.genre = new System.Windows.Forms.TextBox();
            this.auteur = new System.Windows.Forms.TextBox();
            this.titre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this._id = new System.Windows.Forms.TextBox();
            this.update2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChar
            // 
            this.btnChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChar.Location = new System.Drawing.Point(656, 378);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(132, 39);
            this.btnChar.TabIndex = 15;
            this.btnChar.Text = "Charecterestiques";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Location = new System.Drawing.Point(390, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(300, 33);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Ajouter/Modifier Livre";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(175, 378);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(97, 23);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // BooksDataGridView
            // 
            this.BooksDataGridView.AllowUserToDeleteRows = false;
            this.BooksDataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.BooksDataGridView.Location = new System.Drawing.Point(22, 33);
            this.BooksDataGridView.Name = "BooksDataGridView";
            this.BooksDataGridView.ReadOnly = true;
            this.BooksDataGridView.Size = new System.Drawing.Size(250, 339);
            this.BooksDataGridView.TabIndex = 16;
            this.BooksDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksDataGridView_CellContentClick);
            this.BooksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksDataGridView_CellContentClick);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(541, 276);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 25;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // datePub
            // 
            this.datePub.Location = new System.Drawing.Point(516, 232);
            this.datePub.Name = "datePub";
            this.datePub.Size = new System.Drawing.Size(100, 20);
            this.datePub.TabIndex = 24;
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(516, 196);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(100, 20);
            this.genre.TabIndex = 23;
            // 
            // auteur
            // 
            this.auteur.Location = new System.Drawing.Point(516, 165);
            this.auteur.Name = "auteur";
            this.auteur.Size = new System.Drawing.Size(100, 20);
            this.auteur.TabIndex = 22;
            // 
            // titre
            // 
            this.titre.Location = new System.Drawing.Point(516, 130);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(100, 20);
            this.titre.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date Publciation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Auteur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Titre";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(22, 378);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 23);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // _id
            // 
            this._id.Location = new System.Drawing.Point(516, 92);
            this._id.Name = "_id";
            this._id.Size = new System.Drawing.Size(100, 20);
            this._id.TabIndex = 28;
            this._id.Visible = false;
            // 
            // update2
            // 
            this.update2.Location = new System.Drawing.Point(438, 276);
            this.update2.Name = "update2";
            this.update2.Size = new System.Drawing.Size(97, 23);
            this.update2.TabIndex = 29;
            this.update2.Text = "Update";
            this.update2.UseVisualStyleBackColor = true;
            this.update2.Click += new System.EventHandler(this.update2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.update2);
            this.Controls.Add(this._id);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.datePub);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.auteur);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BooksDataGridView);
            this.Controls.Add(this.btnChar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSupprimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DataGridView BooksDataGridView;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox datePub;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.TextBox auteur;
        private System.Windows.Forms.TextBox titre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox _id;
        private System.Windows.Forms.Button update2;
    }
}

