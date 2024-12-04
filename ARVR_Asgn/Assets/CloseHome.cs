using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseHome : MonoBehaviour
{
    public GameObject dimension, dimensionBtn, recommendBtn;

    public void StartGame()
    {
        dimension.SetActive(true);
        dimensionBtn.SetActive(true);
        recommendBtn.SetActive(true);
        gameObject.SetActive(false);
    }
}
