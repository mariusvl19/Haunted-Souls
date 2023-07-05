using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : Weapon_Base
{
    public Animator anim;
    [SerializeField] protected int weaponDamage;
   
    protected void MeleeAttack()
    {
        if (Input.GetMouseButtonDown(1))
        {
            anim.SetBool("hit01", true);
        }
    }
}
