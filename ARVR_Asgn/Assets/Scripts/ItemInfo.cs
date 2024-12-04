using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
public class ItemInfo : MonoBehaviour
{
    public Image mainImage;
    public Sprite Color1, Color2, Color3;
    public MarkerDistSO markerSO;
    public TMP_Text dimensions;
    public List<GameObject> colorButtons = new List<GameObject>();


    private void Update()
    {
        if (markerSO != null)
        {
            if (markerSO.markerDist1 > 0 && markerSO.markerDist2 > 0 && markerSO.markerDist3 > 0)
            {
                dimensions.text = markerSO.markerDist1 + " x " + markerSO.markerDist2 + " x " + markerSO.markerDist3;
            }
        }
    }

    public void ColorButtonsChanger(int index)
    {
        switch (index)
        {
            case 0:
                mainImage.sprite = Color1;
                break;
            case 1:
                mainImage.sprite = Color2;
                break;
            case 2:
                mainImage.sprite = Color3;
                break;
            default:
                break;
        }
    }
}
