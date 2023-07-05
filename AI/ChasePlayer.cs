using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ChasePlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] NavMeshAgent agent;
    
    public void Chase()
    {
      agent.SetDestination(player.transform.position);
    }
}
