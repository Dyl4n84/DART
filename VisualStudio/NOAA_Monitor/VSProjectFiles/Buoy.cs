using System;

namespace BuoyContainer
{
    public class Buoy
    {
        public BuoyDataValues DataSet;

        public Buoy()
        {
            DataSet = new BuoyDataValues();
        }

        public Buoy(Buoy old)
        {

        }

        public void Display()
        {
            DataSet.Display();
        }
    }
}
