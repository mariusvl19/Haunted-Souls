using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveZone : MonoBehaviour
{
    private float pCurrentHealth;
    private float pMaxHealth;
    private int knife;
    private int axe;
    private int bat;
    private int pistol;
    private int shotgun;
    private int magazine_Size;
    private int current_Rounds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SaveScript.saveZone)
        {
            if (SaveScript.enableKnife == true)
            {
                knife = 1;
            }
            if (SaveScript.enableKnife == false)
            {
                knife = 0;
            }

            if (SaveScript.enableAxe == true)
            {
                axe = 1;
            }
            if (SaveScript.enableAxe == false)
            {
                axe = 0;
            }

            if (SaveScript.enableBat == true)
            {
                bat = 1;
            }
            if (SaveScript.enableBat == false)
            {
                bat = 0;
            }

            if (SaveScript.enablePistol == true)
            {
                pistol = 1;
            }
            if (SaveScript.enablePistol == false)
            {
                pistol = 0;
            }

            if (SaveScript.enableShotgun == true)
            {
                shotgun = 1;
            }
            if (SaveScript.enableShotgun == false)
            {
                shotgun = 0;
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                PlayerPrefs.SetFloat("pCurrentHealth", SaveScript.playerCurrentHealth);
                PlayerPrefs.SetFloat("pMaxHealth", SaveScript.playerMaxHealth);
                PlayerPrefs.SetInt("magazine_Size", SaveScript.magazineSize);
                PlayerPrefs.SetInt("current_Rounds", SaveScript.currentRounds);
                PlayerPrefs.SetInt("knife", knife);
                PlayerPrefs.SetInt("axe", axe);
                PlayerPrefs.SetInt("bat", bat);
                PlayerPrefs.SetInt("pistol", pistol);
                PlayerPrefs.SetInt("shotgun", shotgun);
                PlayerPrefs.Save();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            SaveScript.saveZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SaveScript.saveZone = false;
        }
    }
}
