/* Program Name: NOAA Monitor - Maine
 * Written By: Jack Mullen, Prachetas Deshpande, Dylan Rogers, Joshua Wright
 * Description: ...
 *
 ************************************************
 *
 * Last Editted: 11.28.2018
 *
 * TO DO: Josh
 * Pull in buoy station names
 * Set stationList data source to station name
 * Display station data to user
 * Implement OpenWeatherMap into WebView
 * Set Map Mode buttons to change map overlay
 * Display station pictures on stationList click event
 */

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace NOAA_Monitor
{
    public class BuoyList
    {
        public List<Buoy> List_of_buoys;

        public BuoyList()
        {
            List_of_buoys = new List<Buoy>();
        }

        public BuoyList(BuoyList old)
        {
            List_of_buoys = new List<Buoy>();
            int size = old.List_of_buoys.Count;
            for (int i = 0; i < size; i++)
            {
                List_of_buoys.Add(old.List_of_buoys[i]);
            }
        }

        public void Load(string file)
        {
            using (StreamReader read = File.OpenText(file))
            {
                string json = read.ReadToEnd();
                List_of_buoys = JsonConvert.DeserializeObject<List<Buoy>>(json);
            }
        }

        public void Unload(string file)
        {
            string CurrentDate = DateTime.Now.ToString("M_d_yyyy");
            CurrentDate += ".json";
            using (StreamWriter output = File.CreateText(CurrentDate))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(output, List_of_buoys);
            }
        }

        public void BuoyDisplayAll(int index)
        {
            List_of_buoys[index].DisplayAllData();
        }

        public Buoy Search(string target)
        {
            Buoy tmp = new Buoy();

            for (int location = 0; location < List_of_buoys.Count; location++)
            {
                if (List_of_buoys[location].DataSet.BuoyName == target)
                {
                    tmp = List_of_buoys[location];
                    return tmp;
                }
            }
            return tmp;
        }

    }
}
