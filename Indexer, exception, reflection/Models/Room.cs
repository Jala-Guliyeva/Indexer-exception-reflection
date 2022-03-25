using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer__exception__reflection.Models
{
 
        
    internal class Room
    {
        public int Id { get; set; }
        private int _Id = 0;
        public Room()
        {
            Id++;
            Id = _Id;

        }
        public string Name { get; set; }
        public int Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable(bool no)
        {
            bool dflt = true;
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Room(string name, int price, int personcapacity)
        {
            this.Name = name;
            this.Price = price;
            this.PersonCapacity = personcapacity;

        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id}");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"PersonCapacity:{PersonCapacity}"); 
            Console.WriteLine($"Price:{Price}");
        }
        public override string ToString()
        {

            return "Room:" + Id + " " + Name + " " + Price + " " + PersonCapacity;
        }

        public static implicit operator Rooms(Room v)
        {
            throw new NotImplementedException();
        }

    }
}
