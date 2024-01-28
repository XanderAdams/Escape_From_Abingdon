using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.Helper;
public class VoiceOverTrigger : MonoBehaviour
{
    public int triggerCount;
    public int triggerLimit;

    public GameObject teleport;
    public AudioSource _audio;
    
    public Timer timer;

    public void OnTriggerEnter(Collider other)
    {
        triggerCount = triggerCount + 1;
        if (other.CompareTag("Player") && _audio != null && triggerCount < triggerLimit)
        {
            _audio.Play();

            Debug.Log(_audio.clip.length);
            timer.StartTimer(_audio.clip.length);
            
        }

    }

    public void SuperUpdate()
    {
        if (timer.m_timeLeft <= 0)
        {
            Destroy(teleport);
            Destroy(this.gameObject);
            
        }
    }

}
