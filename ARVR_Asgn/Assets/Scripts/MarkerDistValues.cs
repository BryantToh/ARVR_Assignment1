using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MarkerDistValues : MonoBehaviour
{
    [SerializeField]
    MarkerDistSO markerSO;
    [SerializeField]
    private TMP_Text markerDist;

    // Update is called once per frame
    void Update()
    {
        if (markerSO != null)
        {
            markerDist.text = "Marker Distances: " + markerSO.markerDist1 + " x " + markerSO.markerDist2 + " x " + markerSO.markerDist3;
        }
    }
}
