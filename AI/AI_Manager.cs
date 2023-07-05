using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ChasePlayer))]
[RequireComponent(typeof(HorrorMutant_AttackPlayer))]
public class AI_Manager : MonoBehaviour
{

    ChasePlayer _chasePlayer;
    HorrorMutant_AttackPlayer _attackPlayer;
    [SerializeField] GameObject player;

    private void Awake()
    {
        _chasePlayer = GetComponent<ChasePlayer>();
        _attackPlayer = GetComponent<HorrorMutant_AttackPlayer>();
    }
    public enum EnemyState
    {
        Idle,
        Chase,
        Attack
    }
    public EnemyState _enemyState;


    public void SetState()
    {
        switch(_enemyState)
        {
            case EnemyState.Idle:
                Debug.Log("Enemy is Idle");
                break;
            case EnemyState.Chase:
                _chasePlayer.Chase();
                Debug.Log("Enemy is chasing");
                break;
            case EnemyState.Attack:
                Debug.Log("Enemy is attacking");
                break;
        }
    }

   public float DistanceBetween(Transform position1, Transform position2)
   {
       return Vector3.Distance(position1.position, position2.position);
        
   }

    public void StateSetter()
    {
        if(DistanceBetween(player.transform, transform) < 2.0f)
        {
            _enemyState = EnemyState.Attack;
            
        }

        else if(DistanceBetween(player.transform, transform) < 5.0f)
        {
            _enemyState = EnemyState.Chase;
            
        }

        else if(DistanceBetween(player.transform, transform) < 20.0f)
        {
            _enemyState = EnemyState.Idle;
            
        }
    }

    public void Update()
    {
        SetState();
        StateSetter();
    }
}
