using System;

public class Buoy
{

    string bname; //name of buoy
    string[] latlon = new string[2]; //latitude and longitude
    string[] date = new string[5]; //
    string windspeed;
    string winddir;
    string gustspeed;
    string waveheight;
    string domwave;
    string avewave;
    string wavedir;
    string seapress;
    string pressten;
    string airtemp;
    string seatemp;
    string dewtemp;
    string vis;
    string tide;
    public Buoy()
    {
        bname = "NULL";
        for (int i = 0; i < 2; i++)
        {
            latlon[i] = "MM";
        }
        for (int j = 0; j < 5; j++)
        {
            date[j] = "MM";
        }
        windspeed = "MM";
        winddir = "MM";
        gustspeed = "MM";
        waveheight = "MM";
        domwave = "MM";
        avewave = "MM";
        wavedir = "MM";
        seapress = "MM";
        pressten = "MM";
        seatemp = "MM";
        airtemp = "MM";
        dewtemp = "MM";
        vis = "MM";
        tide = "MM";
    }

    public void input(string ins)
    {
        /*ins bname;
        ins >> latlon[0];
        ins >> latlon[1];
        ins >> date[0];
        ins >> date[1];
        ins >> date[2];
        ins >> date[3];
        ins >> date[4];
        ins >> windspeed;
        ins >> winddir;
        ins >> gustspeed;
        ins >> waveheight;
        ins >> domwave;
        ins >> avewave;
        ins >> wavedir;
        ins >> seapress;
        ins >> pressten;
        ins >> seatemp;
        ins >> airtemp;
        ins >> dewtemp;
        ins >> vis;
        ins >> tide;*/
        char[] sep = { ' ' };
        string[] inline = ins.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        bname = inline[0];
        latlon[0] = inline[1];
        latlon[1] = inline[2];
        date[0] = inline[3];
        date[1] = inline[4];
        date[2] = inline[5];
        date[3] = inline[6];
        date[4] = inline[7];
        winddir = inline[8];
        windspeed = inline[9];
        gustspeed = inline[10];
        waveheight = inline[11];
        domwave = inline[12];
        avewave = inline[13];
        wavedir = inline[14];
        seapress = inline[15];
        pressten = inline[16];
        seatemp = inline[17];
        airtemp = inline[18];
        dewtemp = inline[19];
        vis = inline[20];
        tide = inline[21];
    }
    public void display()
    {
        Console.WriteLine(bname);
        Console.WriteLine("Coordinates are ({0},{1})", latlon[0], latlon[1]);
        Console.WriteLine("Date is {0}-{1}-{2} at {3}:{4}", date[1], date[2], date[0], date[3], date[4]);
        Console.WriteLine("Wind speed is {0} with a direction of {1}", windspeed, winddir);
        Console.WriteLine("Gust speed is {0}", gustspeed);
        Console.WriteLine("Wave Height is {0}", waveheight);
        Console.WriteLine("Dominant wave is {0}", domwave);
        Console.WriteLine("Average wave is {0}", avewave);
        Console.WriteLine("Wave direction is {0}", wavedir);
        Console.WriteLine("Sea pressure is {0}", seapress);
        Console.WriteLine("Pressure tendency is {0}", pressten);
        Console.WriteLine("Sea temperature is {0}", seatemp);
        Console.WriteLine("Air temperature is {0}", airtemp);
        Console.WriteLine("Dewpoint temperature is {0}", dewtemp);
        Console.WriteLine("Visibility is {0}", vis);
        Console.WriteLine("Tide is {0}", tide);
    }

    public string getbname()
    {
        return bname;
    }

    public string getlatlon()
    {
        string s = "(" + latlon[0] + "," + latlon[1] + ")";
        return s;
    }

    public string getdate()
    {
        string s = date[1] + "-" + date[2] + "-" + date[0] + " at " + date[3] + ":" + date[4];
        return s;
    }

    public string getwindspeed()
    {
        return windspeed;
    }

    public string getgustspeed()
    {
        return gustspeed;
    }

    public string getwaveheight()
    {
        return waveheight;
    }

    public string getdomwave()
    {
        return domwave;
    }

    public string getavewave()
    {
        return avewave;
    }

    public string getwavedir()
    {
        return wavedir;
    }

    public string getseapress()
    {
        return seapress;
    }

    public string getpressten()
    {
        return pressten;
    }

    public string getseatemp()
    {
        return seatemp;
    }

    public string getairtemp()
    {
        return airtemp;
    }

    public string getdewtemp()
    {
        return dewtemp;
    }

    public string getvis()
    {
        return vis;
    }

    public string gettide()
    {
        return tide;
    }
}
