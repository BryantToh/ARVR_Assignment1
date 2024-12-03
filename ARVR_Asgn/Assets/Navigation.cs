using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    [SerializeField]
    private GameObject Recommendation, Dimension/*, Shop*/;

    private void Start()
    {
        resetTabs();
    }

    public void DimensionTab()
    {
        resetTabs();
        Dimension.SetActive(true);
    }
    public void RecommendationTab()
    {
        resetTabs();
        Recommendation.SetActive(true);
    }
    //public void Shoptab()
    //{
    //    resetTabs();
    //    Shop.SetActive(true);
    //}
    public void resetTabs()
    {
        Dimension.SetActive(false);
       // Shop.SetActive(false);
        Recommendation.SetActive(false);
    }
}
