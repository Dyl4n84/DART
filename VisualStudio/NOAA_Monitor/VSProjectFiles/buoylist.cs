using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace BuoyContainer
{
    public class ListOfBuoys
    {
        List<Buoy> BuoyList;
        public ListOfBuoys()
        {
            BuoyList = new List<Buoy>();
        }
         
        public ListOfBuoys(ListOfBuoys old)
        {
            BuoyList = new List<Buoy>();
            int size = old.BuoyList.Count;
            for (int i = 0; i < size; i++)
            {
                BuoyList.Add(old.BuoyList[i]);
            }
        }

        public void Load(string file)
        {
            using(StreamReader read = File.OpenText(file))
            {
                string json = read.ReadToEnd();
                BuoyList = JsonConvert.DeserializeObject<List<Buoy>>(json);
            }
        }

        public void Unload(string file)
        {
            string CurrentDate = DateTime.Now.ToString("M_d_yyyy");
            CurrentDate += ".json";
            using(StreamWriter output = File.CreateText(CurrentDate))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(output, BuoyList);
            }
        }

        public void BuoyDisplay(int index)
        {
            BuoyList[index].Display();
            return;
        }

        public void DisplayAll()
        {
            for(int location = 0; location < BuoyList.Count; location++)
            {
                BuoyList[location].Display();
            }
            return;
        }

        public Buoy Search(string target)
        {
            Buoy tmp = new Buoy();

            for(int location = 0; location < BuoyList.Count; location++)
            {
                if (BuoyList[location].DataSet.BuoyName == target)
                {
                    tmp = BuoyList[location];
                    return tmp;
                }
            }
            return tmp;
        }

    }
}
