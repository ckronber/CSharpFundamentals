using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruit
{
    public class Banana : IFruit
    {
        public Banana() { }
        public Banana(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
        public string Name
        {
            get
            {
                return "Banana";
            }
        }

        public bool IsPeeled { get; private set; }

        public string Peel()
        {
            IsPeeled = true;
            return "You peeled the Banana";
        }
    }

    public class Orange : IFruit
    {
        public Orange() { }
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        public string Name
        {
            get
            {
                return "Orange";
            }
        }
        public bool IsPeeled { get; private set; }

        // Use the same interface method but bodies can be different as long as the return type matches
        public string Peel()
        {
            if (IsPeeled == true)
                return "Its already peeled";
            else
            {
                IsPeeled = true;
                return "You peeled the orange";
            }
        }

        //Classes that use interfaces can stilll have unique properties and methods.
        public string Squeeze()
        {
            return "You squeeze the orange, and juice comes out";
        }

        public class grape : IFruit
        {
            public string Name
            {
                get
                {
                    return "Grape";
                }
            }

            public bool IsPeeled { get; } = false; //hard set to get false becasue noone is going to peel a grape

            public string Peel()
            {
                return "Who peels grapes";
            }
        }

        //make an apple class inheriting  from Ifruit

        public class apple:IFruit
        {
            public string Name
            {
                get
                {
                    return "apple";
                }
            }
            public bool IsPeeled { get; private set; }

            public string Peel()
            {
                if(IsPeeled == true)
                {
                    return "Already Peeled";
                }
                IsPeeled = true;
                return "You Peeled the Apple.";
            }

            public string ThrowApple()
            {
                return "You threw the apple and it smashed into a bunch  of small pieces";
            }
        }

    }
}
