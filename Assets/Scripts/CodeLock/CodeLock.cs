using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeLock : MonoBehaviour
{
    int placeInCode;
    int codeLength;

    public string code = "";
    public string attemptedCode;

    public Collider collider;

    public AudioSource audioSource;
    public AudioSource sourceAudio;
    void Start()
    {
        codeLength = code.Length;
    }

    void CheckCode()
    {
        if(attemptedCode == code)
        {
            collider.enabled = false;
            sourceAudio.Play();
        }
    }

    public void SetValue(string value)
    {
        placeInCode++;

        if(placeInCode <= codeLength)
        {
            attemptedCode += value;
            audioSource.Play();

        }

        if(placeInCode == codeLength)
        {
            CheckCode();

            attemptedCode = "";
            placeInCode = 0;
        }
    }
}
