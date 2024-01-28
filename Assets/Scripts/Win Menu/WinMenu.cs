using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMenu : MonoBehaviour
{
    public GameObject crossHair;
    public GameObject winScreen;

    public FPSCamera playerCamera;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Win();
        }
    }

    public void Win()
    {
        winScreen.SetActive(true);
        Time.timeScale = 0f;
        crossHair.SetActive(false);
        playerCamera.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
