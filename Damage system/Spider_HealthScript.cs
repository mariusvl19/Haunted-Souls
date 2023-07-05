using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider_HealthScript : MonoBehaviour
{
    public float enemyCurrentHealth = 30f;
    public static bool isEnemyDead = false;
    public Animator anim;
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip spiderDeathSound;
    public void EnemyTakesDamage(float damage)
    {
        enemyCurrentHealth -= damage;
        if (enemyCurrentHealth <= 0 && !isEnemyDead)
        {
            anim.SetBool("isDead", true);
            isEnemyDead = true;
            _audioSource.PlayOneShot(spiderDeathSound);
            Destroy(gameObject, 5);
        }
    }
}

