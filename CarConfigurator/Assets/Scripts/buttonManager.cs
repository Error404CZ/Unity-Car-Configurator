using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonManager : MonoBehaviour
{
    public partsManager partsManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void WheelUpButton()
    {
        partsManager.WheelsUp();
    }

    public void WheelDownButton()
    {
        partsManager.WheelsDown();
    }

    public void SpoilersUpButton()
    {
        partsManager.SpoilersUp();
    }

    public void SpoliersDownButton()
    {
        partsManager.SpoilrsDown();
    }
}
