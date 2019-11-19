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
    }
}
