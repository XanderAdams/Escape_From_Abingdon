using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public GameObject appleText;
    
    private bool isInRange = false;

    public AudioSource vr;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isInRange == true)
        {
            appleText.SetActive(true);
        }
        if (isInRange == false)
        {
            appleText.SetActive(false);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            vr.Play();
            isInRange = true;
            Debug.Log("Fuck'Em thats why");
            if (Input.GetMouseButton(0))
            {
                appleText.SetActive(false);
                Destroy(gameObject);
            }
        }
        else
        {
            isInRange = false;
        }
    }
}
