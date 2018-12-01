using System;
using System.Collections.Generic;
using System.IO;


public class BuoyList
{
    /**
     *
     *
     *
     */
    public List<Buoy> blist;
	public BuoyList()
	{
        blist = new List<Buoy>();
	}

    public void load(string file)
    {
        string[] lines = File.ReadAllLines(file);
        for (int i = 2; i < lines.Length; i++) //i starts at two to skip the first two header lines of the file.
        {
            Buoy temp = new Buoy();
            temp.input(lines[i]);
            blist.Add(temp);
        }
    }

    public void bdisplay(int index)
    {
        blist[index].display();
    }

    public void search(string target)
    {
        for(int i = 0; i < blist.Count; i++){
            if (target == blist[i].getbname())
            {
                blist[i].display();
                return;
            }
        }
        Console.WriteLine("Not found");
        return;
    }

    public BuoyList(BuoyList a)
    {
        blist = new List<Buoy>();
        int size = a.blist.Count;
        for (int i=0; i < size; i++)
        {
            blist.Add(a.blist[i]);
        }
    }

}
