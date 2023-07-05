using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorMutant_HealthScript : MonoBehaviour
{
   public float enemyCurrentHealth = 20f;
   public static bool isEnemyDead = false;
   public Animator anim;
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip HorrorMutantDeathSound;
    public void EnemyTakesDamage(float damage)
    {
        enemyCurrentHealth -= damage;
        if(enemyCurrentHealth <= 0 && !isEnemyDead)
        {
            anim.SetBool("isDead", true);
            isEnemyDead = true;
            _audioSource.PlayOneShot(HorrorMutantDeathSound);
            Destroy(gameObject, 5);
        }
    }
}
