using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceOverTrigger : MonoBehaviour
{
    public int triggerCount;
    public int triggerLimit;
    [SerializeField] public AudioClip _audio;

    private void OnTriggerEnter(Collider other)
    {
        triggerCount = triggerCount + 1;
        if (other.CompareTag("Player") && _audio != null)
        {
            AudioSource.PlayClipAtPoint(_audio, other.transform.position);

            
        }
        if(triggerCount <= triggerLimit)
        {
            Destroy(gameObject);
        }
    }

  
}
