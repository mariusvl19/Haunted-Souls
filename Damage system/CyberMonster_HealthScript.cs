using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyberMonster_HealthScript : MonoBehaviour
{
    public float enemyCurrentHealth = 35f;
    public static bool isEnemyDead = false;
    public Animator anim;
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip cyberDeathSound;
    public void EnemyTakesDamage(float damage)
    {
        enemyCurrentHealth -= damage;
        if (enemyCurrentHealth <= 0 && !isEnemyDead)
        {
            anim.SetBool("isDead", true);
            isEnemyDead = true;
            _audioSource.PlayOneShot(cyberDeathSound);
            Destroy(gameObject, 5);
        }
    }
}

