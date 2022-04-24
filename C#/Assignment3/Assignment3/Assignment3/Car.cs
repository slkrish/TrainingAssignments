using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Car
    {
       private int carno;
       private string carname;
       private string cartype;
       private double cost=0;
        
        public int Carno
        {
            get { return carno; }
            set { carno = value; }
        }
        public string Carname
        {
            get { return carname; }     
            set { carname = value; }
        }
        public string Cartype
        {
            get { return cartype; }
            set { cartype = value; }
        }
        public double Cost
        {
            get { return cost; }
        }
       public Car(int carno,string carname,string cartype)
        {
            this.carno = carno;
            this.carname = carname;
            this.cartype = cartype;
        }
        public void showDetails()
        {
            Console.WriteLine("Car no is "+carno+" , car name is "+carname+" and car type is "+cartype+" and cost is "+cost);
            
        }
    }
}
