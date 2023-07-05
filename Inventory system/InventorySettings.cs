using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySettings : MonoBehaviour
{
    [SerializeField] GameObject Inventory;
    private bool InventoryActivated = false;
    void Start()
    {
        Inventory.gameObject.SetActive(false);
        InventoryActivated = false;
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            if(InventoryActivated == false)
            {
                Inventory.gameObject.SetActive(true);
                InventoryActivated = true;
            }

            else if(InventoryActivated == true)
            {
                Inventory.gameObject.SetActive(false);
                InventoryActivated = false;
            }
        }
    }
}
