﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour {

    public static bool GameisPaused = false;
    public static bool LoadingMenu = false;
    public GameObject pauseMenuUI;
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPaused)
            {
                Resume();

            }
            else
            {

                Pause();
            }
        }
	}

    public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;

    }

    void Pause() {  

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }

    public void LoadMenu()
    {
        LoadingMenu = true;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");

    }

    public void QuitMenu() {

        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
