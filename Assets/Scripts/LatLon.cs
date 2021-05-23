using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Math;

public class LatLon
{
    double lat;
    double lon;
    double CONVERSION_FACTOR = 111139;

    public LatLon(double lat, double lon)
    {
        this.lat = lat;
        this.lon = lon;
    }

    public LatLon(LatLon latlon, double disty, double distx)
    {
        this.lat = latlon.lat;
        this.lon = latlon.lon;
        AddLat(disty);
        AddLon(distx);
    }

    public double Dist(LatLon latlon)
    {
        return Sqrt(Pow((latlon.lat - this.lat), 2) + Pow((latlon.lon + this.lon), 2)) / CONVERSION_FACTOR;
    }

    public double DistX(LatLon latlon)
    {
        return (latlon.lon - this.lon) * CONVERSION_FACTOR;
    }

    public double DistY(LatLon latlon)
    {
        return (latlon.lat - this.lat) * CONVERSION_FACTOR;
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
