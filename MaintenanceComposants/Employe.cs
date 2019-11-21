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
                return emp_prenom + " " + emp_nom;
            }
        }

        public bool IsFemme
        {
            get { return emp_sexe == "F"; }
            set
            {
                if(value)
                {
                    emp_sexe = "F";
                }
                else
                {
                    emp_sexe = "M";
                }
            }
        }
        public bool IsHomme
        {
            get { return emp_sexe == "M"; }
            set
            {
                if (value)
                {
                    emp_sexe = "M";
                }
                else
                {
                    emp_sexe = "F";
                }
            }
        }

    }
}
