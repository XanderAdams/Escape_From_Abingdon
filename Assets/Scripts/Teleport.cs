using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportationLocation;
    
    public GameObject thePlayer;

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            thePlayer.transform.position = teleportationLocation.transform.position;
            
        }

    }
      

}