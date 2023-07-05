using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundItem_Knife : MonoBehaviour, iPickupable
{
    [SerializeField] GameObject knifeImage;
    public void Pickup()
    {
       // Debug.Log("Hello, I am a knife!");
        knifeImage.SetActive(true);
        GetComponent<EquipItem>();
        Destroy(gameObject);
    }
}
