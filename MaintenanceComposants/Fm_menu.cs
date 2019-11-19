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
    public partial class Fm_menu : Form
    {
        private Modele bd; //creation de la variable bd avec le type Modele
        public Fm_menu()
        {
            InitializeComponent();
            bd = new Modele();//instanciation du Modele
        }

        private void btn_diplome_Click(object sender, EventArgs e)//penser à modifier la variable dans le designer
        {
            Fm_diplome fdip = new Fm_diplome(bd); //création de la variable fdip avec le type Fm_diplome avec l'instanciation de Fm_diplome(bd)
            fdip.ShowDialog();//affiche la fenetre fm_diplome
        }

        private void bt_employe(object sender, EventArgs e)
        {
            Fm_employe femp = new Fm_employe(bd);
            femp.ShowDialog();
        }
    }
}
