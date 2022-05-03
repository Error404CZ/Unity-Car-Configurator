using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> defaultButtons = new List<GameObject>();
    [HideInInspector] public List<GameObject> buttons = new List<GameObject>();

    [SerializeField] private GameObject prefabButton;
    [SerializeField] private GameObject HornButton;
    
    public PartsManager partsManager;
    public CameraManager cameraManager;

    private Vector3 defaultButtonTransform;
    
    [SerializeField] private AudioSource audioSourceHorn;

    [SerializeField] private GameObject backButton;

    


    // Start is called before the first frame update
    void Start()
    {
        foreach (var type in defaultButtons)
        {
            type.SetActive(true);
        }
        
        
        backButton.SetActive(false);
        
        HornButton.SetActive(false);
        
    }

    private void VectorConfig()
    {
        defaultButtonTransform.x = -940;
        defaultButtonTransform.y = 490;
        defaultButtonTransform.z = 0;
    }

    

    public void Wheels()
    {
        VectorConfig();
        
        cameraManager.CameraPoints(0);

        foreach (var type in defaultButtons)
        {
            type.SetActive(false);
        }

        foreach (var wheel in partsManager.wheels)
        {
            GameObject button = Instantiate(prefabButton) as GameObject;
            
            button.transform.parent = GameObject.Find("NextButtons").transform;
            button.transform.localPosition = defaultButtonTransform;
            
            button.GetComponent<Button>().onClick.AddListener(() =>
            {
                partsManager.WheelsChange(wheel);
            });

            button.GetComponentInChildren<TextMeshProUGUI>().text = wheel.name;
            
            
            defaultButtonTransform.y -= 75;
        }
        
        backButton.SetActive(true);
    }

    public void Spoilers()
    {
        VectorConfig();
        
        cameraManager.CameraPoints(1);
        
        foreach (var type in defaultButtons)
        {
            type.SetActive(false);
        }

        foreach (var spoiler in partsManager.spoilers)
        {
            GameObject button = Instantiate(prefabButton) as GameObject;
            
            button.transform.parent = GameObject.Find("NextButtons").transform;
            button.transform.localPosition = defaultButtonTransform;
            
            button.GetComponent<Button>().onClick.AddListener(() =>
            {
                partsManager.SpoilersChange(spoiler);
            });
            
            button.GetComponentInChildren<TextMeshProUGUI>().text = spoiler.name;
            
            defaultButtonTransform.y -= 75;
            
        }
        
        backButton.SetActive(true);
    }

    public void BodyColor()
    {
        VectorConfig();
        
        cameraManager.CameraPoints(2);
        
        foreach (var type in defaultButtons)
        {
            type.SetActive(false);
        }

        foreach (var material in partsManager.materials)
        {
            GameObject button = Instantiate(prefabButton) as GameObject;
            
            button.transform.parent = GameObject.Find("NextButtons").transform;
            button.transform.localPosition = defaultButtonTransform;
            
            button.GetComponent<Button>().onClick.AddListener(() =>
            {
                partsManager.BodyCollorChange(material);
            });
            
            button.GetComponentInChildren<TextMeshProUGUI>().text = material.name;
            
            defaultButtonTransform.y -= 75;
            
        }
        
        backButton.SetActive(true);
    }
    
    public void Horn()
    {
        VectorConfig();
        
        HornButton.SetActive(true);
        
        foreach (var type in defaultButtons)
        {
            type.SetActive(false);
        }

        foreach (var horn in partsManager.horn)
        {
            GameObject button = Instantiate(prefabButton) as GameObject;
            
            button.transform.parent = GameObject.Find("NextButtons").transform;
            button.transform.localPosition = defaultButtonTransform;
            
            button.GetComponent<Button>().onClick.AddListener(() =>
            {
                partsManager.HornChange(horn);
            });

            button.GetComponentInChildren<TextMeshProUGUI>().text = horn.name;
            
            
            defaultButtonTransform.y -= 75;
        }
        
        backButton.SetActive(true);
    }
    
    public void Back()
    {
        foreach (var variaButton in buttons)
        {
            Destroy(variaButton);
        }

        foreach (var variaDefaultButton in defaultButtons)
        {
            variaDefaultButton.SetActive(true);
        }
        
        backButton.SetActive(false);
        
        HornButton.SetActive(false);
        
        cameraManager.BackCamera();
    }

    public void PlayHorn()
    {
        audioSourceHorn.Play();
    }
}
