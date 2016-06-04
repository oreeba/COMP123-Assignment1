using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Program Name: The Hero Class (Assignment 1)
 *Student Name: Oreeba Badar
 *Student ID: 300735072
 *Last Date Modified: 2016-06-03
 *Program Description: Create a Hero class with the private instance variables: strength, speed, health and name. The program assign's a random 
 *                     number between 1 and 100 to the abilities (strength, speed, health). Depending on the hero's attempt to hit, the program
 *                     will display the hero's damage caused. The program will then display the hero's ability scroes to the console.
 *                     determine the damage if hero hits the target and display appropriate messages to the 
 *                     console. 
 *GitHub: https://github.com/oreeba/COMP123-Assignment1.git                     
 * 
 */

namespace COMP123_Assignment1
{
   
    class Program
    
    {
        static void Main(string[] args)
        {
         
                Hero newHero = new Hero("Rayaan");
                newHero.Show();  //call show method to display hero's abilities
                newHero.Fight(); //call fight method 

                Console.WriteLine("Press any key to exit");
                Console.ReadKey();

            }
        }
    }


   

