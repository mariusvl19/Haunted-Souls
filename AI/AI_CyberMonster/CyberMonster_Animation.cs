using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AI_Manager))]
public class CyberMonster_Animation : MonoBehaviour
{
    [SerializeField] GameObject player;

    public Animator anim;
    AI_Manager _manager;
    void Start()
    {
        _manager = GetComponent<AI_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimationSetter();
    }

    void AnimationSetter()
    {
        switch (_manager._enemyState)
        {
            case AI_Manager.EnemyState.Idle:
                anim.SetInteger("speed", 0);
                break;
            case AI_Manager.EnemyState.Chase:
                anim.SetInteger("speed", 7);
                transform.LookAt(player.transform.position);
                break;
            case AI_Manager.EnemyState.Attack:
                anim.SetTrigger("Attack");
                transform.LookAt(player.transform.position);
                break;
        }

    }
}
