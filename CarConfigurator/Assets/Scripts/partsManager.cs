using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PartsManager : MonoBehaviour
{
    public List<GameObject> wheels = new List<GameObject>();
    public List<GameObject> spoilers = new List<GameObject>();
    public List<Material> materials = new List<Material>();

    [SerializeField] private Renderer carBody;

    public SaveData saveData;
    public DataManager dataManager;
    
    // Start is called before the first frame update
    void Start()
    {
        dataManager.LoadData();

        try
        {
            foreach (var typ in wheels)
            {
                typ.SetActive(false);
            }
            saveData.saveWheels.SetActive(true);
        }
        catch
        {
            foreach (var typ in wheels)
            {
                typ.SetActive(false);
            }
            wheels[0].SetActive(true);
        }

        try
        {
            foreach (var typ in spoilers)
            {
                typ.SetActive(false);
            }
            saveData.saveSpoilers.SetActive(true);

          
        }
        catch
        {
            foreach (var typ in spoilers)
            {
                typ.SetActive(false);
            }
            spoilers[0].SetActive(true);
        }

        try
        {
            carBody.material = saveData.saveBodyMaterial;
        }
        catch
        {
            carBody.material = materials[0];
        }
        
    }
    
    
    public void WheelsChange(GameObject type)
    {
        foreach (var typ in wheels)
        {
            typ.SetActive(false);
        }
        type.SetActive(true);

        saveData.saveWheels = type;
        dataManager.SaveData();
    }

    public void SpoilersChange(GameObject type)
    {
        foreach (var typ in spoilers)
        {
            typ.SetActive(false);
        }
        type.SetActive(true);

        saveData.saveSpoilers = type;
        dataManager.SaveData();
    }

    public void BodyCollorChange(Material type)
    {
        carBody.material = type;

        saveData.saveBodyMaterial = type;
        dataManager.SaveData();
    }
    
}
