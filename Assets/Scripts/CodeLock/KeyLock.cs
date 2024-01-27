using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyLock : MonoBehaviour
{
    public float reachRange = 25.0f;

    public Color newColor = Color.red;
    public GameObject[] objectsToColor;

    private int currentIndex = 0;

    public Camera playerCamera;

    public LayerMask layerMask;

    CodeLock codeLock;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            CheckHitObj();
        }
    }

    public void CheckHitObj()
    {
        RaycastHit hit;
        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, reachRange, layerMask))
        {
            codeLock = hit.transform.gameObject.GetComponentInParent<CodeLock>();

            if(codeLock != null)
            {
                string value = hit.transform.name;
                codeLock.SetValue(value);
            }

            currentIndex = (currentIndex + 1) % objectsToColor.Length;
            ChangeObjectColor();
        }
    }

    void ChangeObjectColor()
    {
        if (objectsToColor.Length > 0)
        {
            Renderer renderer = objectsToColor[currentIndex].GetComponent<Renderer>();

            if (renderer != null)
            {
                renderer.material.color = newColor;
            }
            else
            {
                Debug.Log("Error");
            }
        }
        else
        {
            Debug.Log("Array is Empty");
        }
    }
}
