using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player_HealthScript : MonoBehaviour
{
    public float playerCurrentHealth;
    public float playerMaxHealth = 100f;
    public Slider healthSlider;
    public Text healthText;
    
    public GameObject PlayerDeath;

    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
        PlayerDeath.gameObject.SetActive(false);
    }


    public void PlayerTakesDamage(float damage)
    {
        playerCurrentHealth -= damage;
        if(playerCurrentHealth <= 0)
        {
          PlayerDeath.gameObject.SetActive(true);
        }
    }

    public void Health(float playerCurrentHealth, float playerMaxHealth)
    {
        //healthSlider.playerCurrentHealth = playerMaxHealth;
        healthSlider.value = playerCurrentHealth;
    }
}
