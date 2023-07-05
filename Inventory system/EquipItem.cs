using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EquipItem : MonoBehaviour
{
    public GameObject bat, knife, axe, pistol, shotgun;

    public bool enableBat;
    public bool enableKnife;
    public bool enableAxe;
    public bool enablePistol;
    public bool enableShotgun;
    


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            if(enableBat)
            {
                bat.SetActive(false);
                enableBat = false;
                return;
            }

            if (!enableBat)
            {
                DisableWeapons();
                bat.SetActive(true);
                enableBat = true;
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (enableKnife)
            {
                knife.SetActive(false);
                enableKnife = false;
                return;
            }

            if (!enableKnife)
            {
                DisableWeapons();
                knife.SetActive(true);
                enableKnife = true;
            }
        }
       
       if(Input.GetKeyDown(KeyCode.Alpha3))
       {
            if (enableAxe)
            {
                axe.SetActive(false);
                enableAxe = false;
                return;
            }

            if (!enableAxe)
            {
                DisableWeapons();
                axe.SetActive(true);
                enableAxe = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (enablePistol)
            {
                pistol.SetActive(false);
                enablePistol = false;
                return;
            }

            if (!enablePistol)
            {
                DisableWeapons();
                pistol.SetActive(true);
                enablePistol = true;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (enableShotgun)
            {
                shotgun.SetActive(false);
                enableShotgun = false;
                return;
            }

            if (!enableShotgun)
            {
                DisableWeapons();
                shotgun.SetActive(true);
                enableShotgun = true;
            }
        }
    }

    public void DisableWeapons()
    {
        bat.SetActive(false);
        knife.SetActive(false);
        axe.SetActive(false);
        pistol.SetActive(false);
        shotgun.SetActive(false);
    }
}


