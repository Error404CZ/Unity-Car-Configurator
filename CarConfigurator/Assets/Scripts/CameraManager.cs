using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> camers;
    [SerializeField] private GameObject defaultCamera;

    public bool cameralock = false;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var camera in camers)
        {
            camera.SetActive(false);
        }
        
        defaultCamera.SetActive(true);
    }
    
    public void CameraPoints(int type)
    {
        cameralock = true;
        foreach (var camera in camers)
        {
            camera.SetActive(false);
        }
        
        camers[type].SetActive(true);
    }

    public void BackCamera()
    {
        foreach (var camera in camers)
        {
            camera.SetActive(false);
        }
        
        defaultCamera.SetActive(true);
        cameralock = false;
    }
}
