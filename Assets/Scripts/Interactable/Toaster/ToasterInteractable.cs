using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToasterInteractable : MonoBehaviour
{
    private bool hasSpawned = false;
    private GameObject spawnObject;

    public GameObject prefab;

    public GameObject toasterText;

    public AudioSource stuff;


    //public Collider triggerCollider;

    public Transform playerArm;
    public Transform tub;

    public ToasterObject grabbedObject;

    public ParticleSystem sparks;

    void Start()
    {
        sparks.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (grabbedObject.interactableText.activeSelf)
        {
            if (Input.GetMouseButtonDown(0) && !hasSpawned)
            {
                spawnObject = Instantiate(prefab, playerArm.transform.position, playerArm.transform.rotation);
                FollowPlayer followPlayer = spawnObject.GetComponent<FollowPlayer>();

                if (followPlayer != null)
                {
                    followPlayer.SetTarget(playerArm);
                }
                Destroy(grabbedObject.objectToDestroy);
                hasSpawned = true;
                grabbedObject.interactableText.SetActive(false);
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Tub") && spawnObject != null)
        {
            stuff.Play();
            toasterText.SetActive(true);
            Debug.Log("Fuck'Em thats why");
            if (Input.GetMouseButton(0))
            {
                Destroy(spawnObject);
                GameObject newSpawnObject = Instantiate(prefab, tub.transform.position, tub.transform.rotation);
                sparks.Play();
                hasSpawned = false;
            }
        }
        else
        {
            toasterText.SetActive(false);
        }
    }
}
