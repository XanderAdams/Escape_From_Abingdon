using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashBang : MonoBehaviour
{
    public GameObject whiteScreen;

    public float waitTime = 5.0f;

    public AudioSource flashbang;
    public AudioSource cricket;
    private IEnumerator FlashBangNow()
    {
        flashbang.Play();
        whiteScreen.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        whiteScreen.SetActive(false);
      
    }

    public void Cricket()
    {
        cricket.Play();
    }

    public void WompWomp()
    {
        Application.Quit();
    }
}
