using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorMutant_ChasePlayer : MonoBehaviour
{
    private Animator anim;
   // [SerializeField] AudioSource _audioSource;
   // [SerializeField] AudioClip HorrorMutantChaseSound;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetInteger("speed", 5);
      //  _audioSource.PlayOneShot(HorrorMutantChaseSound);
    }
}
