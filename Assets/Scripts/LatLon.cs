using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Math;

public class LatLon
{
    double lat;
    double lon;
    double CONVERSION_FACTOR = 111139;

    LatLon(double lat, double lon)
    {
        this.lat = lat;
        this.lon = lon;
    }

    LatLon(double lat, double lon, double disty, double distx)
    {
        this.lat = lat;
        this.lon = lon;
        AddLat(disty);
        AddLon(distx);
    }

    public double Dist(LatLon latlon)
    {
        return Sqrt(Pow((latlon.lat - this.lat), 2) + Pow((latlon.lon + this.lon), 2)) / CONVERSION_FACTOR;
    }

    public void AddLat(double dist)
    {
        this.lat += dist / CONVERSION_FACTOR;
    }

    public void AddLon(double dist)
    {
        this.lon += dist / CONVERSION_FACTOR;
    }
}
