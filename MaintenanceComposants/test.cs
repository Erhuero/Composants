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
    public partial class test : Form
    {
        private Modele bd;
        public test(Modele p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            bsTest.DataSource = bd.Service.Include("LesEmployes");
            lb_employeTest.DisplayMember = "Patronyme";
        }
    }
}
