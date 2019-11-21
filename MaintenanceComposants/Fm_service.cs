using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceComposants
{
    public partial class Fm_service : Form
    {
        private Modele bd;
        public Fm_service(Modele p_bd)
        {   
            InitializeComponent();
            bd = p_bd;
            bs.DataSource = bd.Service.Include("LesEmployes");//lie la source grâce à la clé étrangère LesEmployes ce qui permet de recuperer les donnees 
            lb_employe.DisplayMember = "Patronyme";//affiche le patronyme des memebre dans la listBox
        }

        private void Fm_service_Load(object sender, EventArgs e)
        {

        }

        private void lesEmployesBindingSource_CurrentChanged(object sender, EventArgs e) //CurrentChanged est l’événement par défaut pour BindingSource
        {//CurrentChanged événement est déclenché chaque fois Current que la propriété est modifiée pour l’une des raisons suivantes
         //Position actuelle des List modifications, les DataSource propriétés DataMember ou changent
         //l’ajout ou de la suppression d’un élément avant l’élément actuel, 
         //de la suppression ou du déplacement de l’élément actuel lui-même ou du déplacement d’un élément à la position actuelle.

            if(bs.Current != null)
            {
                bd.SaveChanges();
                if(bs.Current.GetType()==typeof(SceProductif))
                {
                    rb_productif.Checked = true;
                    pn_productif.Visible = true;
                    pn_administratif.Visible = true;
                }

                else
                {
                    rb_administratif.Checked = true;
                    pn_productif.Visible = false;
                    pn_administratif.Visible = true;
                }
            }
        }

        private void rb_productif_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bs_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void serviceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if(bs.Current != null)
            {
                bs.EndEdit();
                bd.SaveChanges();
            }
        }

        private void Fm_service_FormClosing(object sender, FormClosedEventArgs e)
        {
            if(bs.Current != null)
            {
                bs.EndEdit();
                bd.SaveChanges();
            }
        }

        private void bt_plusProductif_Click(object sender, EventArgs e)
        {
            bs.Add(new SceProductif());
            bs.RaiseListChangedEvents = false;
            bd.SaveChanges();
            bs.RaiseListChangedEvents = true;
            bs.MoveLast();
            bs.ResetCurrentItem();

        }

        private void bt_plusAdministratif_Click(object sender, EventArgs e)
        {
            bs.Add(new SceAdministratif());
            bs.RaiseListChangedEvents = false;
            bd.SaveChanges();//provoque l'attribution d'une nouvelle valeur pour le champ ser_id par Sql Server
            bs.RaiseListChangedEvents = true;
            bs.MoveLast();
            bs.ResetCurrentItem();

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(bs.Current != null)
            {
                Service leService = (Service)bs.Current;
                if (leService.LesEmployes.Count == 0)
                {
                    bs.RemoveCurrent();
                    bd.SaveChanges();
                    bs.DataSource = bd.Service.Include("LesEmployes");
                }

                else
                {
                    MessageBox.Show("Impossible de supprimer ce service, des employés y sont affectés !");
                }
            }
        }
    }
}
