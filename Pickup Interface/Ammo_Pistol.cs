using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo_Pistol : MonoBehaviour, iPickupable
{
    [SerializeField] GameObject ammoChargePistol;
    [SerializeField] Pistol _pistol;
    public void Pickup()
    {
       // if (ammoChargePistol)
        _pistol.currentRounds += 30;
        Destroy(gameObject);
    }
}
