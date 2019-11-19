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
    }
}
