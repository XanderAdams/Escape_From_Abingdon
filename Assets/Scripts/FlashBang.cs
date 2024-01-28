using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashBang : MonoBehaviour
{
    public GameObject whiteScreen;
    public GameObject dodgeRollScreen;

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

    private IEnumerator DodgeRoll()
    {
        dodgeRollScreen.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        WompWomp();
      
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
