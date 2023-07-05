using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundItem_Axe : MonoBehaviour, iPickupable
{
    [SerializeField] GameObject axeImage;

    public void Pickup()
    {
        axeImage.SetActive(true); // we enable the image on pickup.
        GetComponent<EquipItem>();
        Destroy(gameObject);
    }
}
