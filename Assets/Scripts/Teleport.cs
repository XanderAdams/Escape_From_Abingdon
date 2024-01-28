using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportationLocation;
    
    public GameObject thePlayer;

    public float clipLength = 0f;

    public VoiceOverTrigger audioPlaying;

    void Update()
    {
        for (int i = 0; i < audioPlaying._audio.clip.length; i++)
        {
            clipLength++;

            clipLength = clipLength * Time.fixedDeltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            thePlayer.transform.position = teleportationLocation.transform.position;
            
        }

        if( audioPlaying._audio.clip.length <= clipLength)
        {
            Destroy(gameObject);
        }


    }
      

}