using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject furnitureMarker;
    private PlacementMarker placement;
    public List<GameObject> posMarkerList = new List<GameObject>();
    int markerCount = 0;
    void Start()
    {
        placement = FindObjectOfType<PlacementMarker>();
    }

    public void SpawnMarker()
    {
        if (posMarkerList.Count < 4)
        {
            // Add a new marker if the list is not full
            GameObject obj = Instantiate(objectToSpawn, placement.transform.position, placement.transform.rotation);
            posMarkerList.Add(obj);
        }
        else
        {
            // Move the oldest marker to the new position if the list is full
            GameObject oldestMarker = posMarkerList[0];
            oldestMarker.transform.position = placement.transform.position;
            oldestMarker.transform.rotation = placement.transform.rotation;

            // Move the marker to the end of the list to keep track of recent updates
            posMarkerList.RemoveAt(0);
            posMarkerList.Add(oldestMarker);
        }
    }

    GameObject furMarkobj;

    public void SpawnFurMarker()
    {
        if (furMarkobj == null)
        {
            furMarkobj = Instantiate(furnitureMarker, placement.transform.position, placement.transform.rotation);
            markerCount++;
        }
        else
        {
            furMarkobj.transform.position = placement.transform.position;
            furMarkobj.transform.rotation = placement.transform.rotation;
        }
    }
}
