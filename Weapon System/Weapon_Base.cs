using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon_Base : MonoBehaviour
{
    [SerializeField] protected float timer;
    [SerializeField] protected float fireRate;
   

    IEnumerator AttackAnimation()
    {
        Vector3 startPos = transform.position;
        Vector3 targetPos = transform.position;
        targetPos.z += 0.25f;
        transform.position = targetPos;
        yield return new WaitForSeconds(0.1f);

        transform.position = startPos;
    }
}

