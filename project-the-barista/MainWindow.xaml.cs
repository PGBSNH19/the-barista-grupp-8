using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace project_the_barista
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {





        //-----------------------------------------------------------------------------
        // Beverage
        //-----------------------------------------------------------------------------				
        class Beverage
        {
            private string   sName             = null;
            private int      iEspresso         = 0;
            private int      iMilk             = 0;
            private int      iMilkFoam         = 0;
            private int      iChocolateSyrup   = 0;
            private int      iWater            = 0;
            List<string>    vCustomItems = new List<string>();
            // vector <string> vCustomerSpecific; 

            //public Beverage addWater(int iAmmount)
            //{
            //    iMilk = iAmmount;
            //    return this;
            //}

            //public Beverage addEspresso(int iAmmount)
            //{
            //    iEspresso = iAmmount;
            //    return this;
            //}


            public Beverage customizeOrder(string sItem)
            {
                vCustomItems.Add(sItem);
                return this;
            }


            //public Beverage addName(int iAmmount)
            //{
            //    iMilk = iAmmount;
            //    return this;
            //}
            public Beverage addEspresso(int iAmmount)
            {
                iEspresso = iAmmount;
                return this;
            }
            public Beverage addMilk(int iAmmount)
            {
                iMilk = iAmmount;
                return this;
            }
            public Beverage addMilkFoam(int iAmmount)
            {
                iMilkFoam = iAmmount;
                return this;
            }
            public Beverage addChocolateSyrup(int iAmmount)
            {
                iChocolateSyrup = iAmmount;
                return this;
            }
            public Beverage addWater(int iAmmount)
            {
                iWater = iAmmount;
                return this;
            }


            public string getName()
            {
                return this.sName;
            }








            public Beverage SelectBeverage()
            {

                if (iMilk != 0)
                {
                    if (iChocolateSyrup != 0)
                    {
                        sName = "Mocha";
                    }
                    if (iWater != 0)
                    {
                        sName = "Americano";
                    }
                    if (iMilkFoam != 0)
                    {
                        sName = "Cappuccino";
                    }


                    if (iMilk > iEspresso)
                    {
                        sName = "Latte";
                    }
                    if (iMilk < iEspresso)
                    {
                        sName = "Espresso";
                    }
                    
                }

                else
                {
                    sName = "Macchiato";
                }


                //sName = ANSWER
                return this;
            }


        }





        //-----------------------------------------------------------------------------
        // Main
        //-----------------------------------------------------------------------------				
        public MainWindow()
        {
            InitializeComponent();

            Beverage beverage = new Beverage().addChocolateSyrup(0).addEspresso(1).addMilk(0).addMilkFoam(1).addWater(0).SelectBeverage();
            Console.WriteLine( beverage);
            Console.WriteLine(beverage.getName());


        }
    }
}
