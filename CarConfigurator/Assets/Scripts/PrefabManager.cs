using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabManager : MonoBehaviour
{
    [SerializeField] GameObject prefabManager;
    // Start is called before the first frame update
    void Start()
    {
        prefabManager.SetActive(false);
    }
}
