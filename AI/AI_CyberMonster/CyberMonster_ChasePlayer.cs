using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyberMonster_ChasePlayer : MonoBehaviour
{
    private Animator anim;
   // [SerializeField] AudioSource _audioSource;
   // [SerializeField] AudioClip cyberChaseSound;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetInteger("speed", 5);
       // _audioSource.PlayOneShot(cyberChaseSound);
    }
}

