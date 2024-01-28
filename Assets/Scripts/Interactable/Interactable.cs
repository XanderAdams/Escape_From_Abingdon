using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private bool hasSpawned = false;
    
    public GameObject prefab;

    public Transform playerArm;

    public PickupObject grabObject;

    // Update is called once per frame
    void Update()
    {
        if(grabObject.interactableText.activeSelf)
        {
            if (Input.GetMouseButtonDown(0) && !hasSpawned)
            {
                GameObject spawnObject = Instantiate(prefab, playerArm.transform.position, playerArm.transform.rotation);
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

}
