using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public int height;
    public int width;
    int mapSize = 1000;
    double mPerPixelX;
    double mPerPixelY;
    LatLon location;
    LatLon upperLeft;
    // Start is called before the first frame update
    void Start()
    {
        Input.location.Start();
        mPerPixelX = width / mapSize;
        mPerPixelY = height / mapSize;
    }

    LatLon LocationInfoToLatLon(LocationInfo data)
    {
        return new LatLon(data.latitude, data.longitude);
    }


    // Update is called once per frame
    void Update()
    {
        UpdateLocation();
        DestroyChildren();
    }

    void UpdateLocation()
    {
        location = LocationInfoToLatLon(Input.location.lastData);
        upperLeft = new LatLon(location, -mapSize / 2, -mapSize / 2);
    }

    void DestroyChildren()
    {
        var children = new List<GameObject>();
        foreach (Transform child in transform) children.Add(child.gameObject);
        children.ForEach(child => Destroy(child));
    }
}
