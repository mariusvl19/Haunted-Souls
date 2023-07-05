using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider_AttackPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] UnityEngine.AI.NavMeshAgent agent;
    float attackCooldown = 3; // 3 second cooldown
    float attackTimer = 0;
   // [SerializeField] AudioSource _audioSource;
   // [SerializeField] AudioClip spiderAttackSound;
    public void Attack()
    {
        attackTimer += Time.deltaTime;
        if (attackTimer > attackCooldown)
        {
            // Attack/damage the player! 
            attackTimer = 0;
            //_audioSource.PlayOneShot(spiderAttackSound);
        }
    }
}

