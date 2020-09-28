namespace CBPlus
{
    partial class ListProduit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Code = new System.Windows.Forms.ColumnHeader();
            this.Nom = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBCodeProduit = new System.Windows.Forms.TextBox();
            this.tBNom = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SupButton = new System.Windows.Forms.Button();
            this.ChargeButton = new System.Windows.Forms.Button();
            this.afficheButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TBProduitCherche = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.codeCol = new System.Windows.Forms.ColumnHeader();
            this.nomCol = new System.Windows.Forms.ColumnHeader();
            this.dateCol = new System.Windows.Forms.ColumnHeader();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listView1.Columns.Add(this.Nom);
            this.listView1.Columns.Add(this.Code);
            this.listView1.Columns.Add(this.Date);
            this.listView1.FullRowSelect = true;
            listViewItem3.Text = "";
            this.listView1.Items.Add(listViewItem3);
            this.listView1.Location = new System.Drawing.Point(291, 104);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(331, 245);
            this.listView1.TabIndex = 0;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Code
            // 
            this.Code.Text = "Code";
            this.Code.Width = 110;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 127;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 91;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(144, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.Text = "Code produit :";
            this.label1.ParentChanged += new System.EventHandler(this.label1_ParentChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(144, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.Text = "Date de péremption :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(144, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.Text = "Nom du produit :";
            // 
            // tBCodeProduit
            // 
            this.tBCodeProduit.Location = new System.Drawing.Point(291, 16);
            this.tBCodeProduit.Name = "tBCodeProduit";
            this.tBCodeProduit.Size = new System.Drawing.Size(331, 23);
            this.tBCodeProduit.TabIndex = 6;
            // 
            // tBNom
            // 
            this.tBNom.Location = new System.Drawing.Point(291, 45);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(331, 23);
            this.tBNom.TabIndex = 8;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(291, 355);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(160, 30);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Ajouter";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(291, 74);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(331, 24);
            this.dateTimePicker.TabIndex = 21;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // SupButton
            // 
            this.SupButton.Location = new System.Drawing.Point(480, 355);
            this.SupButton.Name = "SupButton";
            this.SupButton.Size = new System.Drawing.Size(142, 30);
            this.SupButton.TabIndex = 22;
            this.SupButton.Text = "Supprimer";
            this.SupButton.Click += new System.EventHandler(this.SupButton_Click);
            // 
            // ChargeButton
            // 
            this.ChargeButton.Location = new System.Drawing.Point(7, 30);
            this.ChargeButton.Name = "ChargeButton";
            this.ChargeButton.Size = new System.Drawing.Size(132, 38);
            this.ChargeButton.TabIndex = 26;
            this.ChargeButton.Text = "Charger la BDD";
            this.ChargeButton.Click += new System.EventHandler(this.ChargeButton_Click);
            // 
            // afficheButton
            // 
            this.afficheButton.Location = new System.Drawing.Point(48, 133);
            this.afficheButton.Name = "afficheButton";
            this.afficheButton.Size = new System.Drawing.Size(176, 30);
            this.afficheButton.TabIndex = 30;
            this.afficheButton.Text = "Afficher le produit";
            this.afficheButton.Click += new System.EventHandler(this.afficheButton_Click_1);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.Text = "Nom du produit :";
            this.label4.ParentChanged += new System.EventHandler(this.label4_ParentChanged);
            // 
            // TBProduitCherche
            // 
            this.TBProduitCherche.Location = new System.Drawing.Point(131, 104);
            this.TBProduitCherche.Name = "TBProduitCherche";
            this.TBProduitCherche.Size = new System.Drawing.Size(132, 23);
            this.TBProduitCherche.TabIndex = 33;
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listView2.Columns.Add(this.nomCol);
            this.listView2.Columns.Add(this.codeCol);
            this.listView2.Columns.Add(this.dateCol);
            this.listView2.FullRowSelect = true;
            listViewItem4.Text = "";
            this.listView2.Items.Add(listViewItem4);
            this.listView2.Location = new System.Drawing.Point(7, 212);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(269, 173);
            this.listView2.TabIndex = 38;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // codeCol
            // 
            this.codeCol.Text = "Code";
            this.codeCol.Width = 63;
            // 
            // nomCol
            // 
            this.nomCol.Text = "Nom";
            this.nomCol.Width = 79;
            // 
            // dateCol
            // 
            this.dateCol.Text = "Date";
            this.dateCol.Width = 124;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(26, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 23);
            this.label5.Text = "Date de péremption la plus proche";
            // 
            // ListProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.TBProduitCherche);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.afficheButton);
            this.Controls.Add(this.ChargeButton);
            this.Controls.Add(this.SupButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.tBNom);
            this.Controls.Add(this.tBCodeProduit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Menu = this.mainMenu1;
            this.Name = "ListProduit";
            this.Text = "CBPlus";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBCodeProduit;
        private System.Windows.Forms.TextBox tBNom;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button SupButton;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button ChargeButton;
        private System.Windows.Forms.Button afficheButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBProduitCherche;
        public System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader codeCol;
        private System.Windows.Forms.ColumnHeader nomCol;
        private System.Windows.Forms.ColumnHeader dateCol;
        private System.Windows.Forms.Label label5;
    }
}

