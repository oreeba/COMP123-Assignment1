using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment1
{
    class Hero
    {
        //PRIVATE INSTANCE VARIABLES ***************************************************
        private int _strength;
        private int _speed;
        private int _health;
        private string _name;

        // PUBLIC PROPERTIES ***********************************************************
        /**
         *<summary>
         *This is a property for our _name field
         *</summary>
         *@property {string} Name
         */
         public string Name
        {
            get
            {
                return this._name;
            }
           set
            {
                this._name = value; 
            }
        }
        // constructor method
        public Hero (String name)
        {
            generateAbilities()
        }




    }
}
