using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (MenuScript.LoadGame)
        {
            SaveScript.playerCurrentHealth = PlayerPrefs.GetFloat("pCurrentHealth");
            SaveScript.playerMaxHealth = PlayerPrefs.GetFloat("pMaxHealth");
            SaveScript.magazineSize = PlayerPrefs.GetInt("magazine_Size");
            SaveScript.currentRounds = PlayerPrefs.GetInt("current_Rounds");

            if (PlayerPrefs.GetInt("knife") == 1)
            {
                SaveScript.enableKnife = true;
            }
            if (PlayerPrefs.GetInt("knife") == 0)
            {
                SaveScript.enableKnife = false;
            }

            if (PlayerPrefs.GetInt("axe") == 1)
            {
                SaveScript.enableKnife = true;
            }
            if (PlayerPrefs.GetInt("axe") == 0)
            {
                SaveScript.enableKnife = false;
            }

            if (PlayerPrefs.GetInt("bat") == 1)
            {
                SaveScript.enableKnife = true;
            }
            if (PlayerPrefs.GetInt("bat") == 0)
            {
                SaveScript.enableKnife = false;
            }

            if (PlayerPrefs.GetInt("pistol") == 1)
            {
                SaveScript.enableKnife = true;
            }
            if (PlayerPrefs.GetInt("pistol") == 0)
            {
                SaveScript.enableKnife = false;
            }

            if (PlayerPrefs.GetInt("shotgun") == 1)
            {
                SaveScript.enableKnife = true;
            }
            if (PlayerPrefs.GetInt("shotgun") == 0)
            {
                SaveScript.enableKnife = false;
            }
        }

        if(!MenuScript.LoadGame)
        {
            SaveScript.playerCurrentHealth = 100f;
            SaveScript.playerMaxHealth = 100f;
            SaveScript.magazineSize = 0;
            SaveScript.currentRounds = 0;
            SaveScript.enableKnife = false;
            SaveScript.enableAxe = false;
            SaveScript.enableBat = false;
            SaveScript.enablePistol = false;
            SaveScript.enableShotgun = false;
            SaveScript.saveZone = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
