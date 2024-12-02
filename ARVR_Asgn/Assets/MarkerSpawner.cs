using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    private PlacementMarker placement;
    // Start is called before the first frame update
    void Start()
    {
        placement = FindObjectOfType<PlacementMarker>();
    }

    public void SpawnObject()
    {
        GameObject obj = Instantiate(objectToSpawn, placement.transform.position, placement.transform.rotation);
    }
}
