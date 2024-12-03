using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine;

public class PlacementMarker : MonoBehaviour
{
    private ARRaycastManager rayManager;
    private GameObject visual;
    // Start is called before the first frame update
    void Start()
    {
        rayManager = FindAnyObjectByType<ARRaycastManager>();
        visual = transform.GetChild(0).gameObject;
        visual.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        rayManager.Raycast(new Vector2(Screen.width / 2.0f, Screen.height / 2.0f), hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;
            visual.SetActive(true);
        }
        else
            visual.SetActive(false);
    }
}
