using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour, Iinteractable
{
    [SerializeField] GameObject doorMessage;
    [SerializeField] Text doorText;
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip doorSound;

    public Transform GetTransform()
    {
        return transform;
    }
  


    public void Interact(string animTrigger)
    {
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            if (hit.collider != null)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Iinteractable interactableDoor = hit.collider.GetComponent<Iinteractable>();

                    if (interactableDoor != null)
                    {
                        DoorController door = interactableDoor.GetTransform().GetComponent<DoorController>();
                        Animator anim = interactableDoor.GetTransform().GetComponent<Animator>();
                       
                        
                        if(door.isOpen)
                        {
                            interactableDoor.Interact("Close");
                            doorMessage.SetActive(false);
                            doorText.text = "Press E to close";
                            _audioSource.PlayOneShot(doorSound);
                        }
                        else
                        {
                            interactableDoor.Interact("Open");
                            doorMessage.SetActive(true);
                            doorText.text = "Press E to open";
                            _audioSource.PlayOneShot(doorSound);
                        }
                    }


                    
                }
            }
        }
    }

    public void Update()
    {
        Interact("Open");
    }
}

