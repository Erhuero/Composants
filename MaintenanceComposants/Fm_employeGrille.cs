﻿using System;
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
    public partial class Fm_employeGrille : Form
    {
        private Modele bd;
        public Fm_employeGrille(Modele p_bd)
        {
            InitializeComponent();
            bd = new Modele();
            bd = p_bd;
            bs.DataSource = bd.Employe;//initialisation de la source de données Employe
        }

        private void dg_employe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
