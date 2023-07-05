using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundItem_BaseballBat : MonoBehaviour, iPickupable
{
    [SerializeField] GameObject batImage; // this is the bat image in your inventory that we disabled.

    public void Pickup()
    {
        batImage.SetActive(true); // we enable the image on pickup.
        GetComponent<EquipItem>();
        Destroy(gameObject);
    }
}


