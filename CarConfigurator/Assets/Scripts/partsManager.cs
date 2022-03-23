using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PartsManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> wheels = new List<GameObject>();
    [SerializeField] private List<GameObject> spoilers = new List<GameObject>();
    [SerializeField] private List<Material> materials = new List<Material>();

    [SerializeField] private Renderer carBody;
    // Start is called before the first frame update
    private int wheelsType = 0;
    private int spoilersType = 0;
    private int bodyMaterialType = 0;
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
        
        carBody.material = materials[bodyMaterialType];
        
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

    public void MaterialUp()
    {
        if (bodyMaterialType < materials.Count - 1)
        {
            bodyMaterialType++;
            carBody.material = materials[bodyMaterialType];
        }
    }

    public void MaterialDown()
    {
        if (bodyMaterialType > 0)
        {
            bodyMaterialType--;
            carBody.material = materials[bodyMaterialType];
        }
    }
}
