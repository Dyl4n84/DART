using System;
using System.Collections.Generic;
using System.IO;


public class buoylist
{
    /**
     * 
     * 
     * 
     */
    List<buoy> blist;
	public buoylist()
	{
        blist = new List<buoy>();
	}

    public void load(string file)
    {
        string[] lines = File.ReadAllLines(file);
        for (int i = 2; i < lines.Length; i++) //i starts at two to skip the first two header lines of the file.
        {
            buoy temp = new buoy();
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

}
