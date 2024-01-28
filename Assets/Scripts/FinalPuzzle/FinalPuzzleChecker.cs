using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPuzzleChecker : MonoBehaviour
{
    public ToasterInteractable toaster;
    public Interactable microwave;

    public GameObject[] objectsWithColliders;

    public GameObject whiteScreen;
    public GameObject crossHair;

    public float waitTime = 5.0f;

    private bool coroutineStarted = false;


    void Update()
    {
        FinalChecker();
    }

    public void FinalChecker()
    {
        if(toaster.sparks.isPlaying == true && microwave.sparks.isPlaying == true)
        {
            Debug.Log("It's Working FUCK Yall");
            DisableAllColliders();

            if (!coroutineStarted)
            {
                StartCoroutine(FlashBang());
                coroutineStarted = true;
            }
        }
    }

    void DisableAllColliders()
    {
        foreach (GameObject obj in objectsWithColliders)
        {
            if (obj != null)
            {
                // Disable colliders on the GameObject
                Collider[] colliders = obj.GetComponentsInChildren<Collider>();

                foreach (Collider collider in colliders)
                {
                    collider.enabled = false;
                }
            }
            else
            {
                Debug.Log("Missing Collider recived Null fix now.");
            }
        }
    }

    private IEnumerator FlashBang()
    {
        whiteScreen.SetActive(true);
        crossHair.SetActive(false);
        yield return new WaitForSeconds(waitTime);
        whiteScreen.SetActive(false);
        crossHair.SetActive(true);
    }
}
