using System;
using System.IO;

public class buoy
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

        string bname; ///< The Buoy ID
        string[] latlon = new string[2]; ///< The latitude longitude coordinates of the buoy
        string[] date = new string[5]; ///< The date and time of that the data was taken
        string windspeed; ///< Wind speed in meters per second averaged over an eight-minute period for buoys and a two-minute period for land stations.
        string winddir; ///< The direction the wind is coming from in degrees clockwise from true N during the same period used for WSPD
        string gustspeed; ///< Peak five or eight second gust speed in meters per second measured during the eight-minute or two-minute period.
        string waveheight; ///< Significant wave height in meters is calculated as the average of the highest one-third of all of the wave heights during the twenty-minute sampling period.
        string domwave; ///< Dominant wave period seconds is the period with the maximum wave energy.
        string avewave; ///< Average wave period seconds of all waves during the twenty-minute period.
        string wavedir; ///< The direction from which the waves at the dominant period or DPD are coming. The units are degrees from true North increasing clockwise with North as zero degrees and East as ninty degrees. 
        string seapress; ///< Sea level pressure in hPa
        string pressten; ///< the direction plus or minus and the amount of pressure change in hPa for a three hour period ending at the time of observation
        string airtemp; ///< Air temperature in Celsius
        string seatemp; ///< Sea surface temperature in Celsius
        string dewtemp; ///< Dewpoint temperature taken at the same height as the air temperature measurement
        string vis; ///< Station visibility in nautical miles
        string tide; ///< The water level in feet above or below Mean Lower Low Water

	public buoy() 
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
