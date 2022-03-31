using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoveScript : MonoBehaviour
{
    public Transform playerTransform;
    public Rigidbody rb;
    
    //HoverEngine parameters
    private Vector3 hoverEngine;
    public float howerEnginePower;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        



        //HoverEngine
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -Vector3.up, out hit))
        {
            hoverEngine.y = Mathf.Pow(hit.distance, -1)*howerEnginePower;
            rb.AddForce(hoverEngine*Time.deltaTime);
            
        }
    }
}
