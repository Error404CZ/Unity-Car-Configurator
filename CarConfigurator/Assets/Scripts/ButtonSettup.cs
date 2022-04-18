using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSettup : MonoBehaviour
{
    public ButtonManager buttonManager;

    [SerializeField] private GameObject me;
    // Start is called before the first frame update
    void Start()
    {
        buttonManager.buttons.Add(me);
    }
}
