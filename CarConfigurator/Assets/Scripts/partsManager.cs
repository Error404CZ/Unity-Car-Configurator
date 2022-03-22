using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class partsManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> wheels = new List<GameObject>();
    [SerializeField] private List<GameObject> spoilers = new List<GameObject>();
    // Start is called before the first frame update
    private int wheelsType = 0;
    private int spoilersType = 0;
    void Start()
    {
        foreach (var typ in wheels)
        {
            typ.SetActive(false);
        }
        wheels[wheelsType].SetActive(true);
        
        foreach (var typ in spoilers)
        {
            typ.SetActive(false);
        }
        spoilers[spoilersType].SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WheelsUp()
    {
        if (wheelsType < wheels.Count -1)
        {
            foreach (var typ in wheels)
            {
                typ.SetActive(false);
            }
            
            wheelsType++;
            wheels[wheelsType].SetActive(true);
        }
    }

    public void WheelsDown()
    {
        if (wheelsType > 0)
        {
            foreach (var typ in wheels)
            {
                typ.SetActive(false);
            }
            
            wheelsType--;
            wheels[wheelsType].SetActive(true);
        }
    }
    public void SpoilersUp()
    {
        if (spoilersType < spoilers.Count -1)
        {
            foreach (var typ in spoilers)
            {
                typ.SetActive(false);
            }
            
            spoilersType++;
            spoilers[spoilersType].SetActive(true);
        }
    }
    public void SpoilrsDown()
    {
        if (spoilersType > 0)
        {
            foreach (var typ in spoilers)
            {
                typ.SetActive(false);
            }
            
            spoilersType--;
            spoilers[spoilersType].SetActive(true);
        }
    }
}
