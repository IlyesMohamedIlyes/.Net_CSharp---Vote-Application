namespace VoteApplication
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
            this.textBox_Matricule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Specialite = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Duree = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Debut = new System.Windows.Forms.TextBox();
            this.label_PourPourcentage = new System.Windows.Forms.Label();
            this.label_ContrePourcentage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_NombreVote = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Soumettre = new System.Windows.Forms.Button();
            this.panel_PourGreve = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.comboBox_Greve = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label_Pour = new System.Windows.Forms.Label();
            this.label_Contre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Faculte = new System.Windows.Forms.TextBox();
            this.panel_pourcentage = new System.Windows.Forms.Panel();
            this.button_voir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_PourGreve.SuspendLayout();
            this.panel_pourcentage.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Matricule
            // 
            this.textBox_Matricule.Location = new System.Drawing.Point(110, 96);
            this.textBox_Matricule.Name = "textBox_Matricule";
            this.textBox_Matricule.Size = new System.Drawing.Size(147, 20);
            this.textBox_Matricule.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matricule :";
            // 
            // textBox_Specialite
            // 
            this.textBox_Specialite.Location = new System.Drawing.Point(109, 156);
            this.textBox_Specialite.Name = "textBox_Specialite";
            this.textBox_Specialite.Size = new System.Drawing.Size(147, 20);
            this.textBox_Specialite.TabIndex = 3;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Simplified Arabic Fixed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(70, 9);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(661, 33);
            this.label_Name.TabIndex = 4;
            this.label_Name.Text = "Comité Estudiantin Indépendant - USTHB";
            this.label_Name.Click += new System.EventHandler(this.label_Name_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Spécialité :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date de début de la grève";
            // 
            // textBox_Duree
            // 
            this.textBox_Duree.Location = new System.Drawing.Point(141, 37);
            this.textBox_Duree.Name = "textBox_Duree";
            this.textBox_Duree.Size = new System.Drawing.Size(69, 20);
            this.textBox_Duree.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Durée de la grève";
            // 
            // textBox_Debut
            // 
            this.textBox_Debut.Location = new System.Drawing.Point(141, 11);
            this.textBox_Debut.Name = "textBox_Debut";
            this.textBox_Debut.Size = new System.Drawing.Size(147, 20);
            this.textBox_Debut.TabIndex = 8;
            // 
            // label_PourPourcentage
            // 
            this.label_PourPourcentage.AutoSize = true;
            this.label_PourPourcentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PourPourcentage.Location = new System.Drawing.Point(46, 83);
            this.label_PourPourcentage.Name = "label_PourPourcentage";
            this.label_PourPourcentage.Size = new System.Drawing.Size(77, 46);
            this.label_PourPourcentage.TabIndex = 12;
            this.label_PourPourcentage.Text = "0%";
            // 
            // label_ContrePourcentage
            // 
            this.label_ContrePourcentage.AutoSize = true;
            this.label_ContrePourcentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ContrePourcentage.Location = new System.Drawing.Point(256, 83);
            this.label_ContrePourcentage.Name = "label_ContrePourcentage";
            this.label_ContrePourcentage.Size = new System.Drawing.Size(77, 46);
            this.label_ContrePourcentage.TabIndex = 13;
            this.label_ContrePourcentage.Text = "0%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(449, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nombre de votes :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(394, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 153);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_NombreVote
            // 
            this.label_NombreVote.AutoSize = true;
            this.label_NombreVote.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NombreVote.Location = new System.Drawing.Point(567, 71);
            this.label_NombreVote.Name = "label_NombreVote";
            this.label_NombreVote.Size = new System.Drawing.Size(42, 46);
            this.label_NombreVote.TabIndex = 16;
            this.label_NombreVote.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(166, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 46);
            this.label6.TabIndex = 17;
            this.label6.Text = "|";
            // 
            // button_Soumettre
            // 
            this.button_Soumettre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Soumettre.Location = new System.Drawing.Point(109, 362);
            this.button_Soumettre.Name = "button_Soumettre";
            this.button_Soumettre.Size = new System.Drawing.Size(146, 44);
            this.button_Soumettre.TabIndex = 18;
            this.button_Soumettre.Text = "Soumettre";
            this.button_Soumettre.UseVisualStyleBackColor = true;
            this.button_Soumettre.Click += new System.EventHandler(this.button_Soumettre_Click);
            // 
            // panel_PourGreve
            // 
            this.panel_PourGreve.Controls.Add(this.label4);
            this.panel_PourGreve.Controls.Add(this.textBox_Debut);
            this.panel_PourGreve.Controls.Add(this.label5);
            this.panel_PourGreve.Controls.Add(this.textBox_Duree);
            this.panel_PourGreve.Location = new System.Drawing.Point(41, 224);
            this.panel_PourGreve.Name = "panel_PourGreve";
            this.panel_PourGreve.Size = new System.Drawing.Size(298, 92);
            this.panel_PourGreve.TabIndex = 20;
            this.panel_PourGreve.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Pour";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(241, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Contre";
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(726, 267);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(62, 27);
            this.button_delete.TabIndex = 23;
            this.button_delete.Text = "Supprimer";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Greve
            // 
            this.comboBox_Greve.FormattingEnabled = true;
            this.comboBox_Greve.Items.AddRange(new object[] {
            "POUR GREVE",
            "CONTRE GREVE"});
            this.comboBox_Greve.Location = new System.Drawing.Point(129, 177);
            this.comboBox_Greve.Name = "comboBox_Greve";
            this.comboBox_Greve.Size = new System.Drawing.Size(126, 21);
            this.comboBox_Greve.TabIndex = 24;
            this.comboBox_Greve.SelectedIndexChanged += new System.EventHandler(this.comboBox_Greve_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Choix Grève ?";
            // 
            // label_Pour
            // 
            this.label_Pour.AutoSize = true;
            this.label_Pour.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pour.Location = new System.Drawing.Point(46, 35);
            this.label_Pour.Name = "label_Pour";
            this.label_Pour.Size = new System.Drawing.Size(42, 46);
            this.label_Pour.TabIndex = 26;
            this.label_Pour.Text = "0";
            // 
            // label_Contre
            // 
            this.label_Contre.AutoSize = true;
            this.label_Contre.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Contre.Location = new System.Drawing.Point(256, 37);
            this.label_Contre.Name = "label_Contre";
            this.label_Contre.Size = new System.Drawing.Size(42, 46);
            this.label_Contre.TabIndex = 27;
            this.label_Contre.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Faculté :";
            // 
            // textBox_Faculte
            // 
            this.textBox_Faculte.Location = new System.Drawing.Point(109, 130);
            this.textBox_Faculte.Name = "textBox_Faculte";
            this.textBox_Faculte.Size = new System.Drawing.Size(147, 20);
            this.textBox_Faculte.TabIndex = 29;
            // 
            // panel_pourcentage
            // 
            this.panel_pourcentage.Controls.Add(this.label_Contre);
            this.panel_pourcentage.Controls.Add(this.label_Pour);
            this.panel_pourcentage.Controls.Add(this.label9);
            this.panel_pourcentage.Controls.Add(this.label7);
            this.panel_pourcentage.Controls.Add(this.label6);
            this.panel_pourcentage.Controls.Add(this.label_ContrePourcentage);
            this.panel_pourcentage.Controls.Add(this.label_PourPourcentage);
            this.panel_pourcentage.Location = new System.Drawing.Point(413, 120);
            this.panel_pourcentage.Name = "panel_pourcentage";
            this.panel_pourcentage.Size = new System.Drawing.Size(362, 135);
            this.panel_pourcentage.TabIndex = 30;
            this.panel_pourcentage.Visible = false;
            // 
            // button_voir
            // 
            this.button_voir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voir.Location = new System.Drawing.Point(726, 70);
            this.button_voir.Name = "button_voir";
            this.button_voir.Size = new System.Drawing.Size(49, 44);
            this.button_voir.TabIndex = 31;
            this.button_voir.Text = "%";
            this.button_voir.UseVisualStyleBackColor = true;
            this.button_voir.Click += new System.EventHandler(this.button_voir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_voir);
            this.Controls.Add(this.panel_pourcentage);
            this.Controls.Add(this.textBox_Faculte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_Greve);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_Soumettre);
            this.Controls.Add(this.label_NombreVote);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_Specialite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Matricule);
            this.Controls.Add(this.panel_PourGreve);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_PourGreve.ResumeLayout(false);
            this.panel_PourGreve.PerformLayout();
            this.panel_pourcentage.ResumeLayout(false);
            this.panel_pourcentage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Matricule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Specialite;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Duree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Debut;
        private System.Windows.Forms.Label label_PourPourcentage;
        private System.Windows.Forms.Label label_ContrePourcentage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_NombreVote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Soumettre;
        private System.Windows.Forms.Panel panel_PourGreve;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.ComboBox comboBox_Greve;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_Pour;
        private System.Windows.Forms.Label label_Contre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Faculte;
        private System.Windows.Forms.Panel panel_pourcentage;
        private System.Windows.Forms.Button button_voir;
    }
}

