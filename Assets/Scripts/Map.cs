using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Map : MonoBehaviour
{
    public int height;
    public int width;
    public GameObject enemyPrefab;
    int mapSize = 1000;
    int numEnemies = 10;
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
        GlobalControl.Instance.enemies = (from enemy in GlobalControl.Instance.enemies
                                          where location.Dist(enemy.location) < mapSize
                                          select enemy).ToList();
        UpdateLocation();
        CreateEnemies();
        DestroyChildren();
        foreach (Enemy enemy in GlobalControl.Instance.enemies)
        {
            DrawEnemy(enemy);
        }
    }

    void CreateEnemies()
    {
        while (GlobalControl.Instance.enemies.Count < numEnemies)
        {
            GlobalControl.Instance.enemies.Add(CreateEnemy());
        }
    }

    Enemy CreateEnemy()
    {
        double minDist = 0;
        LatLon randomLocation = new LatLon(0, 0);
        while (minDist < 100)
        {
            minDist = mapSize;
            randomLocation = new LatLon(location, UnityEngine.Random.Range(-mapSize / 2, mapSize / 2), UnityEngine.Random.Range(-mapSize / 2, mapSize / 2));
            foreach (Enemy enemy in GlobalControl.Instance.enemies)
            {
                minDist = Math.Min(minDist, randomLocation.Dist(enemy.location));
            }
        }
        return new Enemy(randomLocation, 1, 100, 20);
    }

    void DrawEnemy(Enemy enemy)
    {
        double distX = location.DistX(enemy.location);
        double distY = location.DistY(enemy.location);
        float posX =  (float) (distX / mPerPixelX - width / 2);
        float posY =  (float) (distY / mPerPixelY - width / 2);
        Instantiate(enemyPrefab, new Vector3(posX, posY, 0), Quaternion.identity);
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
