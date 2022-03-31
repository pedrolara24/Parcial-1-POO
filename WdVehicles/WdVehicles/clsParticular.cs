using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WdVehicles
{
    internal class clsParticular
    {
        //se definen las variables y se encapsulan para que puedan ser usadas "parcialmente" segun necesite el usuario
        private string plaque;

        public string Plaque
        {
            get { return plaque; }
            set { plaque = value; }
        }


        private double model;

        public double Model
        {
            get { return model; }
            set { model = value; }
        }

        private string colour;

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }


        private double power;

        public double Power
        {
            get { return power; }
            set { power = value; }
        }
    }
}