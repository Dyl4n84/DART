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
            buoylist listofbuoys = new buoylist();
            listofbuoys.load("test.txt");
            //listofbuoys.bdisplay(0);
            listofbuoys.search("41008");
            buoylist list2 = new buoylist(listofbuoys);
            list2.bdisplay(0);
        }
    }
}
