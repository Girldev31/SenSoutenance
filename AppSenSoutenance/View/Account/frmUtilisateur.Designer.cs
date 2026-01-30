namespace AppSenSoutenance.View.Account
{
    partial class frmUtilisateur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgUtilisateur = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCandidat = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelect = new System.Windows.Forms.Button();
            this.btnSender = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhoneCand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrenomCand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatriculeCand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailCand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomCand = new System.Windows.Forms.TextBox();
            this.tabProfesseur = new System.Windows.Forms.TabPage();
            this.btnEditProf = new System.Windows.Forms.Button();
            this.btnSelectProf = new System.Windows.Forms.Button();
            this.btnDelectProf = new System.Windows.Forms.Button();
            this.btnSenderProf = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneProf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrenomProf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSpecialiteProf = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmailProf = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNomProf = new System.Windows.Forms.TextBox();
            this.tabChDepartement = new System.Windows.Forms.TabPage();
            this.btnEditCd = new System.Windows.Forms.Button();
            this.btnSelectCd = new System.Windows.Forms.Button();
            this.btnDelectCd = new System.Windows.Forms.Button();
            this.btnSenderCd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhoneCd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrenomCd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmailCd = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNomCd = new System.Windows.Forms.TextBox();
            this.cbbDepartement = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCandidat.SuspendLayout();
            this.tabProfesseur.SuspendLayout();
            this.tabChDepartement.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgUtilisateur);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 342);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Utilisateur";
            // 
            // dgUtilisateur
            // 
            this.dgUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtilisateur.Location = new System.Drawing.Point(3, 50);
            this.dgUtilisateur.Name = "dgUtilisateur";
            this.dgUtilisateur.RowHeadersWidth = 62;
            this.dgUtilisateur.RowTemplate.Height = 28;
            this.dgUtilisateur.Size = new System.Drawing.Size(1008, 289);
            this.dgUtilisateur.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(12, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 305);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCandidat);
            this.tabControl1.Controls.Add(this.tabProfesseur);
            this.tabControl1.Controls.Add(this.tabChDepartement);
            this.tabControl1.Location = new System.Drawing.Point(17, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 276);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCandidat
            // 
            this.tabCandidat.Controls.Add(this.btnEdit);
            this.tabCandidat.Controls.Add(this.btnSelect);
            this.tabCandidat.Controls.Add(this.btnDelect);
            this.tabCandidat.Controls.Add(this.btnSender);
            this.tabCandidat.Controls.Add(this.label7);
            this.tabCandidat.Controls.Add(this.txtPhoneCand);
            this.tabCandidat.Controls.Add(this.label5);
            this.tabCandidat.Controls.Add(this.txtPrenomCand);
            this.tabCandidat.Controls.Add(this.label4);
            this.tabCandidat.Controls.Add(this.txtMatriculeCand);
            this.tabCandidat.Controls.Add(this.label3);
            this.tabCandidat.Controls.Add(this.txtEmailCand);
            this.tabCandidat.Controls.Add(this.label2);
            this.tabCandidat.Controls.Add(this.txtNomCand);
            this.tabCandidat.Location = new System.Drawing.Point(4, 29);
            this.tabCandidat.Name = "tabCandidat";
            this.tabCandidat.Padding = new System.Windows.Forms.Padding(3);
            this.tabCandidat.Size = new System.Drawing.Size(972, 243);
            this.tabCandidat.TabIndex = 0;
            this.tabCandidat.Text = "Candidat";
            this.tabCandidat.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEdit.Location = new System.Drawing.Point(637, 130);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 46);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelect.Location = new System.Drawing.Point(813, 44);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(110, 46);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "Selectionner";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDelect
            // 
            this.btnDelect.BackColor = System.Drawing.Color.Red;
            this.btnDelect.Location = new System.Drawing.Point(813, 130);
            this.btnDelect.Name = "btnDelect";
            this.btnDelect.Size = new System.Drawing.Size(110, 46);
            this.btnDelect.TabIndex = 11;
            this.btnDelect.Text = "Supprimer";
            this.btnDelect.UseVisualStyleBackColor = false;
            this.btnDelect.Click += new System.EventHandler(this.btnDelect_Click);
            // 
            // btnSender
            // 
            this.btnSender.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSender.Location = new System.Drawing.Point(637, 45);
            this.btnSender.Name = "btnSender";
            this.btnSender.Size = new System.Drawing.Size(110, 46);
            this.btnSender.TabIndex = 10;
            this.btnSender.Text = "Ajouter";
            this.btnSender.UseVisualStyleBackColor = false;
            this.btnSender.Click += new System.EventHandler(this.btnSender_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Télephone";
            // 
            // txtPhoneCand
            // 
            this.txtPhoneCand.Location = new System.Drawing.Point(48, 166);
            this.txtPhoneCand.Name = "txtPhoneCand";
            this.txtPhoneCand.Size = new System.Drawing.Size(186, 26);
            this.txtPhoneCand.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Prénom";
            // 
            // txtPrenomCand
            // 
            this.txtPrenomCand.Location = new System.Drawing.Point(48, 106);
            this.txtPrenomCand.Name = "txtPrenomCand";
            this.txtPrenomCand.Size = new System.Drawing.Size(186, 26);
            this.txtPrenomCand.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Matricule";
            // 
            // txtMatriculeCand
            // 
            this.txtMatriculeCand.Location = new System.Drawing.Point(311, 54);
            this.txtMatriculeCand.Name = "txtMatriculeCand";
            this.txtMatriculeCand.Size = new System.Drawing.Size(186, 26);
            this.txtMatriculeCand.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // txtEmailCand
            // 
            this.txtEmailCand.Location = new System.Drawing.Point(311, 110);
            this.txtEmailCand.Name = "txtEmailCand";
            this.txtEmailCand.Size = new System.Drawing.Size(186, 26);
            this.txtEmailCand.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // txtNomCand
            // 
            this.txtNomCand.Location = new System.Drawing.Point(48, 45);
            this.txtNomCand.Name = "txtNomCand";
            this.txtNomCand.Size = new System.Drawing.Size(186, 26);
            this.txtNomCand.TabIndex = 0;
            // 
            // tabProfesseur
            // 
            this.tabProfesseur.Controls.Add(this.btnEditProf);
            this.tabProfesseur.Controls.Add(this.btnSelectProf);
            this.tabProfesseur.Controls.Add(this.btnDelectProf);
            this.tabProfesseur.Controls.Add(this.btnSenderProf);
            this.tabProfesseur.Controls.Add(this.label6);
            this.tabProfesseur.Controls.Add(this.txtPhoneProf);
            this.tabProfesseur.Controls.Add(this.label8);
            this.tabProfesseur.Controls.Add(this.txtPrenomProf);
            this.tabProfesseur.Controls.Add(this.label9);
            this.tabProfesseur.Controls.Add(this.txtSpecialiteProf);
            this.tabProfesseur.Controls.Add(this.label10);
            this.tabProfesseur.Controls.Add(this.txtEmailProf);
            this.tabProfesseur.Controls.Add(this.label11);
            this.tabProfesseur.Controls.Add(this.txtNomProf);
            this.tabProfesseur.Location = new System.Drawing.Point(4, 29);
            this.tabProfesseur.Name = "tabProfesseur";
            this.tabProfesseur.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfesseur.Size = new System.Drawing.Size(972, 243);
            this.tabProfesseur.TabIndex = 1;
            this.tabProfesseur.Text = "Professeur";
            this.tabProfesseur.UseVisualStyleBackColor = true;
            // 
            // btnEditProf
            // 
            this.btnEditProf.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEditProf.Location = new System.Drawing.Point(638, 146);
            this.btnEditProf.Name = "btnEditProf";
            this.btnEditProf.Size = new System.Drawing.Size(110, 46);
            this.btnEditProf.TabIndex = 27;
            this.btnEditProf.Text = "Modifier";
            this.btnEditProf.UseVisualStyleBackColor = false;
            this.btnEditProf.Click += new System.EventHandler(this.btnEditProf_Click);
            // 
            // btnSelectProf
            // 
            this.btnSelectProf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelectProf.Location = new System.Drawing.Point(814, 60);
            this.btnSelectProf.Name = "btnSelectProf";
            this.btnSelectProf.Size = new System.Drawing.Size(110, 46);
            this.btnSelectProf.TabIndex = 26;
            this.btnSelectProf.Text = "Selectionner";
            this.btnSelectProf.UseVisualStyleBackColor = false;
            this.btnSelectProf.Click += new System.EventHandler(this.btnSelectProf_Click);
            // 
            // btnDelectProf
            // 
            this.btnDelectProf.BackColor = System.Drawing.Color.Red;
            this.btnDelectProf.Location = new System.Drawing.Point(814, 146);
            this.btnDelectProf.Name = "btnDelectProf";
            this.btnDelectProf.Size = new System.Drawing.Size(110, 46);
            this.btnDelectProf.TabIndex = 25;
            this.btnDelectProf.Text = "Supprimer";
            this.btnDelectProf.UseVisualStyleBackColor = false;
            this.btnDelectProf.Click += new System.EventHandler(this.btnDelectProf_Click);
            // 
            // btnSenderProf
            // 
            this.btnSenderProf.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSenderProf.Location = new System.Drawing.Point(638, 61);
            this.btnSenderProf.Name = "btnSenderProf";
            this.btnSenderProf.Size = new System.Drawing.Size(110, 46);
            this.btnSenderProf.TabIndex = 24;
            this.btnSenderProf.Text = "Ajouter";
            this.btnSenderProf.UseVisualStyleBackColor = false;
            this.btnSenderProf.Click += new System.EventHandler(this.btnSenderProf_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Télephone";
            // 
            // txtPhoneProf
            // 
            this.txtPhoneProf.Location = new System.Drawing.Point(49, 182);
            this.txtPhoneProf.Name = "txtPhoneProf";
            this.txtPhoneProf.Size = new System.Drawing.Size(186, 26);
            this.txtPhoneProf.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Prénom";
            // 
            // txtPrenomProf
            // 
            this.txtPrenomProf.Location = new System.Drawing.Point(49, 122);
            this.txtPrenomProf.Name = "txtPrenomProf";
            this.txtPrenomProf.Size = new System.Drawing.Size(186, 26);
            this.txtPrenomProf.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(308, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Specialite";
            // 
            // txtSpecialiteProf
            // 
            this.txtSpecialiteProf.Location = new System.Drawing.Point(312, 70);
            this.txtSpecialiteProf.Name = "txtSpecialiteProf";
            this.txtSpecialiteProf.Size = new System.Drawing.Size(186, 26);
            this.txtSpecialiteProf.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(308, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Email";
            // 
            // txtEmailProf
            // 
            this.txtEmailProf.Location = new System.Drawing.Point(312, 126);
            this.txtEmailProf.Name = "txtEmailProf";
            this.txtEmailProf.Size = new System.Drawing.Size(186, 26);
            this.txtEmailProf.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "Nom";
            // 
            // txtNomProf
            // 
            this.txtNomProf.Location = new System.Drawing.Point(49, 61);
            this.txtNomProf.Name = "txtNomProf";
            this.txtNomProf.Size = new System.Drawing.Size(186, 26);
            this.txtNomProf.TabIndex = 14;
            // 
            // tabChDepartement
            // 
            this.tabChDepartement.Controls.Add(this.cbbDepartement);
            this.tabChDepartement.Controls.Add(this.btnEditCd);
            this.tabChDepartement.Controls.Add(this.btnSelectCd);
            this.tabChDepartement.Controls.Add(this.btnDelectCd);
            this.tabChDepartement.Controls.Add(this.btnSenderCd);
            this.tabChDepartement.Controls.Add(this.label12);
            this.tabChDepartement.Controls.Add(this.txtPhoneCd);
            this.tabChDepartement.Controls.Add(this.label13);
            this.tabChDepartement.Controls.Add(this.txtPrenomCd);
            this.tabChDepartement.Controls.Add(this.label14);
            this.tabChDepartement.Controls.Add(this.label15);
            this.tabChDepartement.Controls.Add(this.txtEmailCd);
            this.tabChDepartement.Controls.Add(this.label16);
            this.tabChDepartement.Controls.Add(this.txtNomCd);
            this.tabChDepartement.Location = new System.Drawing.Point(4, 29);
            this.tabChDepartement.Name = "tabChDepartement";
            this.tabChDepartement.Padding = new System.Windows.Forms.Padding(3);
            this.tabChDepartement.Size = new System.Drawing.Size(972, 243);
            this.tabChDepartement.TabIndex = 2;
            this.tabChDepartement.Text = "Chef Departement";
            this.tabChDepartement.UseVisualStyleBackColor = true;
            // 
            // btnEditCd
            // 
            this.btnEditCd.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEditCd.Location = new System.Drawing.Point(638, 146);
            this.btnEditCd.Name = "btnEditCd";
            this.btnEditCd.Size = new System.Drawing.Size(110, 46);
            this.btnEditCd.TabIndex = 27;
            this.btnEditCd.Text = "Modifier";
            this.btnEditCd.UseVisualStyleBackColor = false;
            this.btnEditCd.Click += new System.EventHandler(this.btnEditCd_Click);
            // 
            // btnSelectCd
            // 
            this.btnSelectCd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelectCd.Location = new System.Drawing.Point(814, 60);
            this.btnSelectCd.Name = "btnSelectCd";
            this.btnSelectCd.Size = new System.Drawing.Size(110, 46);
            this.btnSelectCd.TabIndex = 26;
            this.btnSelectCd.Text = "Selectionner";
            this.btnSelectCd.UseVisualStyleBackColor = false;
            this.btnSelectCd.Click += new System.EventHandler(this.btnSelectCd_Click);
            // 
            // btnDelectCd
            // 
            this.btnDelectCd.BackColor = System.Drawing.Color.Red;
            this.btnDelectCd.Location = new System.Drawing.Point(814, 146);
            this.btnDelectCd.Name = "btnDelectCd";
            this.btnDelectCd.Size = new System.Drawing.Size(110, 46);
            this.btnDelectCd.TabIndex = 25;
            this.btnDelectCd.Text = "Supprimer";
            this.btnDelectCd.UseVisualStyleBackColor = false;
            this.btnDelectCd.Click += new System.EventHandler(this.btnDelectCd_Click);
            // 
            // btnSenderCd
            // 
            this.btnSenderCd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSenderCd.Location = new System.Drawing.Point(638, 61);
            this.btnSenderCd.Name = "btnSenderCd";
            this.btnSenderCd.Size = new System.Drawing.Size(110, 46);
            this.btnSenderCd.TabIndex = 24;
            this.btnSenderCd.Text = "Ajouter";
            this.btnSenderCd.UseVisualStyleBackColor = false;
            this.btnSenderCd.Click += new System.EventHandler(this.btnSenderCd_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(49, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 24);
            this.label12.TabIndex = 23;
            this.label12.Text = "Télephone";
            // 
            // txtPhoneCd
            // 
            this.txtPhoneCd.Location = new System.Drawing.Point(49, 182);
            this.txtPhoneCd.Name = "txtPhoneCd";
            this.txtPhoneCd.Size = new System.Drawing.Size(186, 26);
            this.txtPhoneCd.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(49, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 24);
            this.label13.TabIndex = 21;
            this.label13.Text = "Prénom";
            // 
            // txtPrenomCd
            // 
            this.txtPrenomCd.Location = new System.Drawing.Point(49, 122);
            this.txtPrenomCd.Name = "txtPrenomCd";
            this.txtPrenomCd.Size = new System.Drawing.Size(186, 26);
            this.txtPrenomCd.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(308, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 24);
            this.label14.TabIndex = 19;
            this.label14.Text = "Departement";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(308, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 24);
            this.label15.TabIndex = 17;
            this.label15.Text = "Email";
            // 
            // txtEmailCd
            // 
            this.txtEmailCd.Location = new System.Drawing.Point(312, 126);
            this.txtEmailCd.Name = "txtEmailCd";
            this.txtEmailCd.Size = new System.Drawing.Size(186, 26);
            this.txtEmailCd.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(49, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 24);
            this.label16.TabIndex = 15;
            this.label16.Text = "Nom";
            // 
            // txtNomCd
            // 
            this.txtNomCd.Location = new System.Drawing.Point(49, 61);
            this.txtNomCd.Name = "txtNomCd";
            this.txtNomCd.Size = new System.Drawing.Size(186, 26);
            this.txtNomCd.TabIndex = 14;
            // 
            // cbbDepartement
            // 
            this.cbbDepartement.FormattingEnabled = true;
            this.cbbDepartement.Location = new System.Drawing.Point(312, 71);
            this.cbbDepartement.Name = "cbbDepartement";
            this.cbbDepartement.Size = new System.Drawing.Size(186, 28);
            this.cbbDepartement.TabIndex = 28;
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 708);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUtilisateur";
            this.Text = "frmUtilisateur";
            this.Load += new System.EventHandler(this.frmUtilisateur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCandidat.ResumeLayout(false);
            this.tabCandidat.PerformLayout();
            this.tabProfesseur.ResumeLayout(false);
            this.tabProfesseur.PerformLayout();
            this.tabChDepartement.ResumeLayout(false);
            this.tabChDepartement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgUtilisateur;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCandidat;
        private System.Windows.Forms.TabPage tabProfesseur;
        private System.Windows.Forms.TabPage tabChDepartement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrenomCand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatriculeCand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailCand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomCand;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelect;
        private System.Windows.Forms.Button btnSender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhoneCand;
        private System.Windows.Forms.Button btnEditProf;
        private System.Windows.Forms.Button btnSelectProf;
        private System.Windows.Forms.Button btnDelectProf;
        private System.Windows.Forms.Button btnSenderProf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneProf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrenomProf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSpecialiteProf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmailProf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNomProf;
        private System.Windows.Forms.Button btnEditCd;
        private System.Windows.Forms.Button btnSelectCd;
        private System.Windows.Forms.Button btnDelectCd;
        private System.Windows.Forms.Button btnSenderCd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPhoneCd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrenomCd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmailCd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNomCd;
        private System.Windows.Forms.ComboBox cbbDepartement;
    }
}