using UnityEngine;

[CreateAssetMenu(fileName = "MarkerDistanceData", menuName = "Marker/MarkerDistSO")]
public class MarkerDistSO : ScriptableObject
{
    public int markerDist1;
    public int markerDist2;
    public int markerDist3;

    public void SetDistance(int index, int distance)
    {
        switch (index)
        {
            case 0:
                markerDist1 = distance;
                break;
            case 1:
                markerDist2 = distance;
                break;
            case 2:
                markerDist3 = distance;
                break;
            default:
                Debug.LogWarning("Invalid index for distance assignment.");
                break;
        }
    }
}
