//******************************************************
//* File Name       = CSAssignment1.cs                 *
//* Name            = Rob Walczak                      *
//* Date            = 08/28/2017                       *
//* Course          = CWEB2010 Advanced Prog           *
//* Assignmnet name = C# Chapters 1-2 Assignment       *
//******************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSAssignment1.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName, lName, cName, item;
            int quantity;
            double cost, tCost;
            double TAX_RATE = .065;

            Write("Please your enter your first name:  ");
            fName = ReadLine();
            Write("{0}'s last name is:   ", fName);
            lName = ReadLine();
            Write("{0} please enter the name of your company:  ",fName);
            cName = ReadLine();
            Write("Item purchased for {0}:  ", cName);
            item = ReadLine();
            Write("Quantity of {0}'s purchased:  ", item);
            quantity = Convert.ToInt32(ReadLine());
            Write("Cost for each {0} : $  ", item);
            cost = Convert.ToDouble(ReadLine());
            WriteLine("Purchase information for {0} {1}, {2}:  ", fName, lName, cName);
            WriteLine("Item purchased:  {0}  ", item);
            WriteLine("Quantity and cost per each {0}: {1} at ${2:F2} each  ", item, quantity, cost);
            tCost = (((cost * quantity) * TAX_RATE) + cost * quantity);
            WriteLine("Total cost: ${0:F2} including a ${1} tax rate ", tCost, TAX_RATE);
            ReadLine();
        }
    }
}
