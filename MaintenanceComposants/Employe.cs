using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceComposants
{
    public partial class Employe
    {
        public string Patronyme
        {
            get
            {
                return emp_nom + "" + emp_prenom;
            }
        }
    }
}
