using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private bool hasSpawned = false;
    private GameObject spawnObject;

    public GameObject prefab;
    
    public GameObject mircowaveText;

    public Collider triggerCollider;

    public Transform playerArm;
    public Transform microwave;

    public PickupObject grabObject;
    public AudioSource spoon;
    public AudioSource michalwave;
    public ParticleSystem sparks;

    void Start()
    {
        sparks.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if(grabObject.interactableText.activeSelf)
        {
            if (Input.GetMouseButtonDown(0) && !hasSpawned)
            {
                spawnObject = Instantiate(prefab, playerArm.transform.position, playerArm.transform.rotation); 
                FollowPlayer followPlayer = spawnObject.GetComponent<FollowPlayer>();

                if (followPlayer != null)
                {
                    followPlayer.SetTarget(playerArm);
                }
                Destroy(grabObject.objectToDestroy);
                hasSpawned = true;
                grabObject.interactableText.SetActive(false);
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Microwave") && spawnObject != null)
        {
            mircowaveText.SetActive(true);
            Debug.Log("Fuck'Em thats why");
            if(Input.GetMouseButton(0))
            {
                michalwave.Play();
                spoon.Play();
                Debug.Log("At microwave");
                Destroy(spawnObject);
                GameObject newSpawnObject = Instantiate(prefab, microwave.transform.position, microwave.transform.rotation);
                sparks.Play();
                hasSpawned = false;
            }   
        }
        else
        {
            mircowaveText.SetActive(false);
        }
    }

}
