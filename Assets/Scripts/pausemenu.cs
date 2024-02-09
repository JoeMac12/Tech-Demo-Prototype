using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour // Controls the pause menu
{
    public GameObject PauseMenu;
    public bool isPaused;

    void Start()
    {
        PauseMenu.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame() // Pause the demo
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame() // Resume the demo
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
