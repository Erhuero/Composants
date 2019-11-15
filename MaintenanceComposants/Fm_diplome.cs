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
    public partial class Fm_diplome : Form
    {
        private Modele bd;
        public Fm_diplome(Modele p_bd)//passage du parametre p_bd avec le type Modele
        {
            InitializeComponent();
            bd = p_bd; //attribution de la variable p_bd à la variable bd (bd devient p_bd)
            bs.DataSource = bd.Diplome;//ajout apres le mode conception, permet d'avoir les données
        }

        private void Fm_diplome_Load(object sender, EventArgs e)
        {

        }

        private void dip_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dip_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void dip_libelleLabel_Click(object sender, EventArgs e)
        {

        }

        private void dip_libelleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lesEmployesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
