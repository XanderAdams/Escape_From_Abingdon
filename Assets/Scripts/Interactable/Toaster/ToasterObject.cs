using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToasterObject : MonoBehaviour
{
    public GameObject interactableText;
    public GameObject objectToDestroy;

    public bool isDetected = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (isDetected == true)
        {
            interactableText.SetActive(true);
        }
        else
        {
            interactableText.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isDetected = true;
        }
        else
        {
            isDetected = false;
        }
    }
}
