using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface Iinteractable
{
    public void Interact(string animTrigger);
    public Transform GetTransform();

}
public class DoorController : MonoBehaviour, Iinteractable
{
    [SerializeField] BoxCollider box;
    public Animator anim;
    public bool isOpen = false;

    // use void pickup method from pickups and then try to call it from the player script, you want to raycast from the player not from the door
    public Transform GetTransform()
    {
        return transform;
    }

    public void Interact(string animTrigger)
    {
        if (!isOpen)
        {
            anim.SetTrigger(animTrigger);
            isOpen = true;
            
        }

        else if (isOpen)
        {
            anim.SetTrigger(animTrigger);
            isOpen = false;
           
        }
    }
    

}
