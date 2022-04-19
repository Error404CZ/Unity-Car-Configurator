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

    public PartsManager partsManager;
    public GameObject partsManagerGameObject;
    

    private Vector3 defaultButtonTransform;

    [SerializeField] private GameObject backButton;
    
    
    // Start is called before the first frame update
    void Start()
    {
        foreach (var typ in defaultButtons)
        {
            typ.SetActive(true);
        }
        
        
        backButton.SetActive(false);
    }


    public void Wheels()
    {
        defaultButtonTransform.x = -940;
        defaultButtonTransform.y = 490;
        defaultButtonTransform.z = 0;
        
        foreach (var typ in defaultButtons)
        {
            typ.SetActive(false);
        }

        foreach (var w in partsManager.wheels)
        {
            GameObject button = Instantiate(prefabButton) as GameObject;
            
            button.transform.parent = GameObject.Find("NextButtons").transform;
            button.transform.localPosition = defaultButtonTransform;
            
            button.GetComponent<Button>().onClick.AddListener(() =>
            {
                partsManager.WheelsChange(w);
            });

            button.GetComponentInChildren<TextMeshProUGUI>().text = w.name;
            
            defaultButtonTransform.y -= 75;
        }
        
        backButton.SetActive(true);
    }

    public void Spoilers()
    {
        defaultButtonTransform.x = -940;
        defaultButtonTransform.y = 490;
        defaultButtonTransform.z = 0;
        
        foreach (var typ in defaultButtons)
        {
            typ.SetActive(false);
        }

        foreach (var s in partsManager.spoilers)
        {
            GameObject button = Instantiate(prefabButton) as GameObject;
            
            button.transform.parent = GameObject.Find("NextButtons").transform;
            button.transform.localPosition = defaultButtonTransform;
            
            button.GetComponent<Button>().onClick.AddListener(() =>
            {
                partsManager.SpoilersChange(s);
            });
            
            button.GetComponentInChildren<TextMeshProUGUI>().text = s.name;
            
            defaultButtonTransform.y -= 75;
            
        }
        
        backButton.SetActive(true);
    }

    public void BodyColor()
    {
        defaultButtonTransform.x = -940;
        defaultButtonTransform.y = 490;
        defaultButtonTransform.z = 0;
        
        foreach (var typ in defaultButtons)
        {
            typ.SetActive(false);
        }

        foreach (var m in partsManager.materials)
        {
            GameObject button = Instantiate(prefabButton) as GameObject;
            
            button.transform.parent = GameObject.Find("NextButtons").transform;
            button.transform.localPosition = defaultButtonTransform;
            
            button.GetComponent<Button>().onClick.AddListener(() =>
            {
                partsManager.BodyCollorChange(m);
            });
            
            button.GetComponentInChildren<TextMeshProUGUI>().text = m.name;
            
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
    }
}
