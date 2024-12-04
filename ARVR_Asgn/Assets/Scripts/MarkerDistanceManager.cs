using System.Collections;
using TMPro;
using UnityEngine;

public class MarkerDistanceManager : MonoBehaviour
{
    public MarkerSpawner markerSpawn;
    public TMP_Text distText;
    public MarkerDistSO markerSO;

    private void Start()
    {
        markerSpawn = GameObject.Find("MarkerSpawner").GetComponent<MarkerSpawner>();
        distText = GameObject.Find("DistanceTxt").GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (markerSpawn != null && markerSpawn.posMarkerList.Count > 1)
        {
            string distancesText = "";

            for (int i = 0; i < markerSpawn.posMarkerList.Count - 1 && i < 3; i++)
            {
                float distanceBetMark = Vector3.Distance(
                    markerSpawn.posMarkerList[i].transform.position,
                    markerSpawn.posMarkerList[i + 1].transform.position
                );

                float distanceInInches = distanceBetMark * 39.37f;
                int roundedDistance = Mathf.RoundToInt(distanceInInches);

                // Update MarkerDistSO object
                markerSO.SetDistance(i, roundedDistance);
                distancesText += $"Marker {i} to Marker {i + 1}: {roundedDistance} inches\n";
            }

            // Display updated distances in the text field
            distText.text = distancesText;
        }
    }

}
