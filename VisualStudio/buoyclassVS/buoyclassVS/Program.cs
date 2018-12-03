using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace buoyclassVS
{
    class Program
    {
        static void Main(string[] args)
        {
            BuoyList listofbuoys = new BuoyList();
            listofbuoys.load("test.txt");
            //listofbuoys.bdisplay(0);
            listofbuoys.search("41008");
            BuoyList list2 = new BuoyList(listofbuoys);
            list2.bdisplay(0);
        }
    }
}
