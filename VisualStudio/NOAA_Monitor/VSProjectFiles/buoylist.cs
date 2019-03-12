using System;
using System.Collections.Generic;
using System.IO;


public class BuoyList
{
    List<Buoy> blist; ///< The list of buoy classes
    /** The constructor of the class
     */
    public BuoyList()
	{
        blist = new List<Buoy>();
	}
    /** Loads from the text file into a list of buoys
     * @param The filename of the input file, preferably a text file
     */
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
    /** Displays the information about a buoy
     * @param The index of the buoy list to be displayed
     */
    public void bdisplay(int index)
    {
        blist[index].display();
    }
    /** Searches through the list for a specific buoy
     * @param The ID (banme) of the buoy to be searched
     */
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
    /** Copy constructor
    * @param buoy list to be copied from
    */
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
