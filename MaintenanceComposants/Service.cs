using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceComposants
{
    public partial class Service
    {


        public String Produit
        {
            get
            {
                if(GetType()== typeof(SceProductif))//typeof affiche le type si le type ser_produit est du même type que la propriété de la table
                {
                    return ((SceProductif)this).ser_produit;//retourne la valeur da table
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if(GetType() == typeof(SceProductif))
                {
                    ((SceProductif)this).ser_produit = value;//insere la valeur dans la table
                }
            }
        }

        public int Capacite
        {
            get
            {
                if(GetType()==typeof(SceProductif))
                {
                    if(((SceProductif)this).ser_capacite != null) //value n'est pas accessible si null
                    {
                        return ((SceProductif)this).ser_capacite;
                    }
                }
                return 0;
            }
            set
            {
                if(GetType()==typeof(SceProductif))
                {
                    ((SceProductif)this).ser_capacite = value;
                }
            }
        }

        public decimal Budget
        {
            get
            {
                if(GetType()== typeof(SceAdministratif))
                {
                    if (((SceAdministratif)this).ser_budget != null)//value n'est pas accessible si null
                    {
                        return ((SceAdministratif)this).ser_budget;
                    }
                }
                return 0;
            }
            set
            {
                if(GetType()==typeof(SceAdministratif))
                {
                    ((SceAdministratif)this).ser_budget = value;
                }
            }
        }
    }
}
