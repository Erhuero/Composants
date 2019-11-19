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
        }
    }
}
