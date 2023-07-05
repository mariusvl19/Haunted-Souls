using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iPickupable
{
    public void Pickup();
}



public class Pickups : MonoBehaviour
{
   
    
    private void Update()
    {
        Pickup();
    }

    void Pickup()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if(hit.collider != null)
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    iPickupable pickupableObject = hit.collider.GetComponent<iPickupable>();

                    if(pickupableObject != null)
                    {
                        pickupableObject.Pickup();
                    }
                }
            }
        }

    }
}
