using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundItem_Pistol : MonoBehaviour, iPickupable
{
    [SerializeField] GameObject pistolImage;

    public void Pickup()
    {
        pistolImage.SetActive(true); // we enable the image on pickup.
        GetComponent<EquipItem>();
        Destroy(gameObject);
    }
}
