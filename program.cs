using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EEG324_GROUP6_Q2
{
    //Class
    public class Vals
    {
        public double primaryVoltage;
        public double secondaryVoltage;
        
        
        //Constructor
        public Vals(double Ep, double Es)
        {
            primaryVoltage = Ep;
            secondaryVoltage = Es;
        }
        //End of constructor
        
        
        //Method
        public void numberOfTurns()
        {
            //Frequency (f) is 50Hertz
            double f = 50;
            
            //maximum flux density(B) is 1.1tesla
            double B = 1.1;
            
            //Area of Core is 17.16cm²
            //Convert to m², => Area = 0.001716m²
            double A = 0.001716;
            
            //Calculate number of turns in primary coil
            double Np = primaryVoltage/(4.44 * f * B *A);
            
            //Display number of turns in primary coil
            Console.WriteLine($"The number of turns in the primary is {Np}");
            
            
            //Calculate number of turns in secondary coil
            double Ns = Np/(primaryVoltage / secondaryVoltage );
            
                 
            //Display number of turns in the secondary coil
            Console.WriteLine($"The number of turns in the Secondary is {Ns}");
            
            //Give space to separate it for each group
            Console.WriteLine("   ");
            
        }
       //End of the Method        
    }
   //End of class Vals  
    
    //Beginning of the app
    class Program
    {
        static void Main(string[] args)
        {
            //Group1 to Group10 are created
            Vals group1 = new Vals(200, 6);
            Vals group2 = new Vals(200, 6);
            Vals group3 = new Vals(210, 9);
            Vals group4 = new Vals(210, 9);
            Vals group5 = new Vals(220, 12);
            Vals group6 = new Vals(220, 12);
            Vals group7 = new Vals(230, 15);
            Vals group8 = new Vals(230, 15);
            Vals group9 = new Vals(240, 25);
            Vals group10 = new Vals(240, 25);
        
        
            //The number of primary & secondary coils for group1 to group10 is displayed
            group1.numberOfTurns();
            group2.numberOfTurns();
            group3.numberOfTurns();
            group4.numberOfTurns();
            group5.numberOfTurns();
            group6.numberOfTurns();
            group7.numberOfTurns();
            group8.numberOfTurns();
            group9.numberOfTurns();
            group10.numberOfTurns();
        }
    }
   //End of App
   
}
//End of Program 
