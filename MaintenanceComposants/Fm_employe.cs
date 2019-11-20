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
    public partial class Fm_employe : Form
    {
        private Modele bd;
        public Fm_employe(Modele p_bd)
        {

            InitializeComponent();
            bd = p_bd;
            bs.DataSource = bd.Employe;//affiche les employes dans les cases
            bs_service.DataSource = bd.Service;//affiche la ComboBox
            bs.DataSource = bd.Employe.Include("LesDiplomes");
            cb_recherche.DisplayMember = "Patronyme";//affiche les champs Patronyme de la liste déroulante

        }

        private void employeBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void emp_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void leServiceLabel_Click(object sender, EventArgs e)
        {

        }

        private void leServiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void emp_cadreCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Fm_employe_Load(object sender, EventArgs e)
        {

        }

        private void lb_diplomesPossedes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lesDiplomesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bt_versAutresDiplomes_Click(object sender, EventArgs e)
        {
            if(bs.Current != null)
            {
                if(lb_diplomesPossedes.SelectedIndex != -1)
                {
                    Employe leEmploye = (Employe)bs.Current;
                    Diplome leDiplome = (Diplome)lb_diplomesPossedes.SelectedItem;

                    leEmploye.LesDiplomes.Remove(leDiplome);
                    bs_autresDiplomes.Add(leDiplome);


                }
            }
        }

        private void bt_versDiplomesPossedes_Click(object sender, EventArgs e)
        {
            if(bs.Current != null)
            {
                if(lb_autresDiplomes.SelectedIndex != -1)
                {
                    Employe leEmploye = (Employe)bs.Current;
                    Diplome leDiplome = (Diplome)lb_autresDiplomes.SelectedItem;
                    leEmploye.LesDiplomes.Add(leDiplome);
                    bs_autresDiplomes.Remove(leDiplome);


                }
            }
        }

        private void bs_CurrentChanged(object sender, EventArgs e)
        {
            if(bs.Current != null)
            {
                Employe leEmploye = (Employe)bs.Current;
                if(leEmploye.LeService==null)
                {
                    cb_service.SelectedIndex = -1;//il faut forcer la propriété SelectedIndex de cb_service
                    //a -1 dans le cas des valeurs nulles pour la propriété LeService
                }
                if(leEmploye.EntityState == EntityState.Detached)
                {
                    bs.EndEdit();
                    bs.RaiseListChangedEvents = false;
                    bd.SaveChanges();
                    bs.RaiseListChangedEvents = true;
                    bs.ResetCurrentItem();
                }
                else
                {
                    bd.SaveChanges();
                }

                bs_autresDiplomes.DataSource = bd.Diplome.ToList().Except(leEmploye.LesDiplomes).ToList();//l'appel de la méthode ToList lors de l'affectation du DataSource
                //de bs_autresDiplomes force la requete Linq à s'éxécuter
                //en l'abscence du dernier ToList(), l'affectation de DisplayMember ci-dessous échoue avec une liste vide    
                lb_autresDiplomes.DisplayMember = "dip_libelle";
            }
        }

        private void employeBindingNavigatorSaveItem_Click(object sender, EventArgs e)//rendre le bouton actif avec la commande Enabled
        {
            if(bs.Current != null)
            {
                bs.EndEdit();
                bd.SaveChanges();//sauvegarde de données dans la base
            }
        }

        private void Fm_employe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(bs.Current != null)
            {
                bs.EndEdit();
                bd.SaveChanges();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
