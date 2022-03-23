using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public PartsManager PartsManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void WheelUpButton()
    {
        PartsManager.WheelsUp();
    }

    public void WheelDownButton()
    {
        PartsManager.WheelsDown();
    }

    public void SpoilersUpButton()
    {
        PartsManager.SpoilersUp();
    }

    public void SpoliersDownButton()
    {
        PartsManager.SpoilrsDown();
    }

    public void MaterialUpButton()
    {
        PartsManager.MaterialUp();
    }

    public void MaterialDownButton()
    {
        PartsManager.MaterialDown();
    }
}
