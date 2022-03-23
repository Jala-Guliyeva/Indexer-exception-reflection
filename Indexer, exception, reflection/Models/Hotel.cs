using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer__exception__reflection.Models
{
    internal class Hotel
    {
        public int name;
        private Rooms[] rms;
           
    }
    public Hotel(int length)
    {
        rms = new Rooms[length];
    }
}
