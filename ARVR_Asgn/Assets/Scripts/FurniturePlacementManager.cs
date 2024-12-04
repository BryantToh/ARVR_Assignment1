using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine;

public class FurniturePlacementManager : MonoBehaviour
{
    public GameObject spawnableFurniture;
    public ARSession session;
    public ARRaycastManager raycastManager;
    public ARPlaneManager planeManager;
    public Transform furMarker;
    public GameObject recommend;
    Vector3 nigga = new Vector3(0, 0, 0);
    private List<ARRaycastHit> hitList = new List<ARRaycastHit>();

    private void Update()
    {

    }

    public void AddFurniture(GameObject furniture)
    {
        furMarker = GameObject.FindGameObjectWithTag("FurMarker").transform;
        Debug.Log("furniture");
        recommend.SetActive(false);
        spawnableFurniture = furniture;
        GameObject obj = Instantiate(spawnableFurniture, furMarker.position, spawnableFurniture.transform.rotation);
        obj.transform.SetParent(null);
    }
}
