using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dropdown : MonoBehaviour
{
    public void DropdownSample(int index)
    {
        switch (index)
        {
            case 0:
                
                break;
            case 1:
                Debug.Log("Sofa");
                break;
            case 2:
                Debug.Log("Table");
                break;
            case 3:
                Debug.Log("Drawer");
                break;
            default:
                break;
        }
    }
}
