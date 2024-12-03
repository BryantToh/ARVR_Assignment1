using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindCamera : MonoBehaviour
{
    private Canvas canvas;

    void Start()
    {
        canvas = GetComponent<Canvas>();

        if (canvas.renderMode == RenderMode.WorldSpace)
        {
            Camera xrMainCamera = Camera.main;

            if (xrMainCamera != null)
            {
                canvas.worldCamera = xrMainCamera;
                Debug.Log("Assigned XR Main Camera: " + xrMainCamera.name);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
