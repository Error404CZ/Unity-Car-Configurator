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
    // Start is called before the first frame update
    void Start()
    {
        foreach (var typ in wheels)
        {
            typ.SetActive(false);
        }
        wheels[0].SetActive(true);
        
        foreach (var typ in spoilers)
        {
            typ.SetActive(false);
        }
        spoilers[0].SetActive(true);
        
        carBody.material = materials[0];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WheelsChange(GameObject type)
    {
        foreach (var typ in wheels)
        {
            typ.SetActive(false);
        }
        type.SetActive(true);
    }

    public void SpoilersChange(GameObject type)
    {
        foreach (var typ in spoilers)
        {
            typ.SetActive(false);
        }
        type.SetActive(true);
    }

    public void BodyCollorChange(Material type)
    {
        carBody.material = type;
    }
    
}
