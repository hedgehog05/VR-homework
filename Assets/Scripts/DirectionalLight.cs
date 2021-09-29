using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalLight : MonoBehaviour
{
    private Light myLight;
    private void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}
