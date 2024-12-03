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
    // Start is called before the first frame update
    void Start()
    {
        placement = FindObjectOfType<PlacementMarker>();
    }

    public void SpawnMarker()
    {
        if (posMarkerList.Count < 4)
        {
            GameObject obj = Instantiate(objectToSpawn, placement.transform.position, placement.transform.rotation);
            posMarkerList.Add(obj);
        }
    }

    public void SpawnFurMarker()
    {
        if (markerCount < 1)
        {
            GameObject furMarkobj = Instantiate(furnitureMarker, placement.transform.position, placement.transform.rotation);
            markerCount++;
        }
        else return;
    }
}
