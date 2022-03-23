using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer__exception__reflection.Models
{
 
        
    internal class Room
    {
        public int Id;
        public string Name { get; set; }
        public int Price;
        public int PersonCapacity { get; set; }
        public bool IsAvailable (int no)
        {
            bool dflt = true;
            if (true)
            {
                return false;
            }
        }
        public Room(string name,int price,int personcapacity)
        {
            this.Name = name;
            this.Price = price;
            this.PersonCapacity = personcapacity;

        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} ");
            Console.WriteLine($"Name:{Name} ");
            Console.WriteLine($"Price:{Price} ");
            Console.WriteLine($"PersonCapacity:{PersonCapacity} ");

     
        }
        public override string ToString()
        {
            return base.ToString(ShowInfo());
        }
        

    }
}
