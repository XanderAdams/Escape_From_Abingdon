using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleVoiceOver : MonoBehaviour
{
    public int triggerCount;
    public int triggerLimit;
    public AudioSource _audio;

    public void OnTriggerEnter(Collider other)
    {
        triggerCount = triggerCount + 1;
        if (other.CompareTag("Player") && _audio != null && triggerCount < triggerLimit)
        {
            _audio.Play();

            
           

        }

    }
}
