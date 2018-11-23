using System;

public class Mapping

{
    // Public Variables - xCoordinate, yCoordinate
    const string appID= "05e8370f9d5eef9f82224881b5853b28";
    public string mapMode { set; get; }
    public string zoomLevel { set; get; }
    public string xCoordinate { set; get; }
    public string yCoordinate { set; get; }
    public string mapURL { set; get; }

    public Mapping()
	{
        xCoordinate = "43.9526";
        yCoordinate = "-68.6722";
        zoomLevel = "0";
        mapMode = "TA2";

        // https://openweathermap.org/weathermap?basemap=map&cities=true&layer=temperature&lat={x}&lon={y}&zoom={zoomLevel}
        mapURL = "https://openweathermap.org/weathermap?basemap=map&cities=true&layer=temperature&" +
            "lat=" + xCoordinate + "&lon=" + yCoordinate + "&zoom=5";
    }

    public Mapping(string _xCoordinate, string _yCoordinate, string _zoomLevel = "0", string _mapMode = "TA2")
    {
        xCoordinate = "43.9526";
        yCoordinate = "-68.6722";
        zoomLevel = "0";
        mapMode = "TA2";

        mapURL = "https://openweathermap.org/weathermap?basemap=map&cities=true&layer=temperature&" +
            "lat=" + xCoordinate + "&lon=" + yCoordinate + "&zoom=5";
    }

    public void setNewMap(string _mapMode)
    {
        
    }

    
}
