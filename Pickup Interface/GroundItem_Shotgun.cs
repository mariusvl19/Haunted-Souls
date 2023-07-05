using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundItem_Shotgun : MonoBehaviour, iPickupable
{
    [SerializeField] GameObject shotgunImage;

    public void Pickup()
    {
        shotgunImage.SetActive(true); // we enable the image on pickup.
        GetComponent<EquipItem>();
        Destroy(gameObject);
    }
}
