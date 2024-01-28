using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkDoor : MonoBehaviour
{
     Animator animator;
    public GameObject door;
    
    // Use this for initialization
    void Start () {
        animator = door.GetComponent<Animator>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("Shrink", true);           

        }

    }
}
