using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace CBPlus
{
    public partial class ListProduit : Form
    {
        // Connection à la base de donnée SqlCe
        public SqlCeConnection cn = new SqlCeConnection(@"Data source = .\Produit.sdf");

        // Création de la listeView listviewBase qui servira à stocker temporairement la listeView 
        // principal afin de faire la recherche d'article
        public ListView listviewBase = new ListView();
           

        // Ouverture de la connection au lancement
        private void Form1_Shown(Object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            }
            catch (SqlCeException er)
            {
                MessageBox.Show(er.Message,"Erreur à l'ouverture de la bdd");
                Application.Exit();
            }
        }

        public ListProduit()
        {
            InitializeComponent();
        }

        // ListView principale
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView ListView1 = new ListView();
            ListView1.Name = "ListView1"; 
        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        // Ajout de nouveaux articles
        private void AddButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();

            item.Text = tBCodeProduit.Text.Trim();
            item.SubItems.Add(tBNom.Text.Trim());
            item.SubItems.Add(dateTimePicker.Text.Trim());

            listView1.Items.Add(item);
            SauvergardeListView(listView1); 

            tBCodeProduit.Text = String.Empty;
            tBNom.Text = String.Empty;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        
        // Suppression d'un article
        private void SupButton_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                //foreach (System.Windows.Forms.ListViewItem item in this.listView1.SelectedItems)
                /*foreach (ListViewItem item in listView1)
                {
                    if (item.Selected)
                        listView1.Items.Remove(item);
                }*/

                
            }
        }

        // Charger la listeView des éléments de la base de donnée
        private void ChargeButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM Produit", cn);
            try
            {
                
                SqlCeDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(dataReader["Nom"].ToString());
                    item.SubItems.Add(dataReader["CodeBarre"].ToString());
                    item.SubItems.Add(dataReader["DateExp"].ToString());

                    listView1.Items.Add(item);
                }
            }
            catch (SqlCeException er)
            {
                MessageBox.Show(er.Message, "Erreur au chargement de la bdd");
            }
        }

        private void label4_ParentChanged(object sender, EventArgs e)
        {

        }
        
        // Liste qui affiche le résultat de la recherche avec le code-barre
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView ListView2 = new ListView();
            ListView2.Name = "ListView2";
        }

       
        // Affiche le résultat dans la listView
        private void afficheButton_Click_1(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            string nom = TBProduitCherche.Text.Trim();

            UpdateListView2(listviewBase, listView2, nom);
            
        }

        // Permet de stocker temporairement la listeView principale
        public void SauvergardeListView(ListView listView)
        {
            listviewBase.Items.Clear();

            foreach (ListViewItem item in listView.Items)
            {
                this.listviewBase.Items.Add((ListViewItem)item.Clone());
            }
        }

        // Met a jour la listeView de la recherche
        public void UpdateListView2(ListView listViewBase, ListView listview2, string nom)
        {
            listview2.Items.Clear();

            foreach (ListViewItem item in listViewBase.Items)
            {
                if (item.Text.ToString() == nom)
                {
                    //MessageBox.Show("égal: "+item.Text.ToString()+" "+code);
                    listview2.Items.Add((ListViewItem)item.Clone());
                }
                
            }
        }

        
        
        
    }
}