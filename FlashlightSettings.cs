using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightSettings : MonoBehaviour
{
    [SerializeField] GameObject Flashlight;
    private bool flashlightActivated;

    void Start()
    {
        Flashlight.gameObject.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (flashlightActivated == false)
            {
                flashlightActivated = true;
                Flashlight.gameObject.SetActive(true);
            }
            else
            {
                flashlightActivated = false;
                Flashlight.gameObject.SetActive(false);
            }
        }
    }
}

