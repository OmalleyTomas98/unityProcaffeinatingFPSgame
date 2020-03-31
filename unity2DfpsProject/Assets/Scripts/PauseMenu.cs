using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIspaused=false;

    public GameObject pauseMenuUI;


    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIspaused)
            {
                Resume();
             } else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Debug.Log("Resuem Hit");
        Time.timeScale = 1f;
        GameIspaused = false;

    }

    void Pause()
    {
        
        pauseMenuUI.SetActive(true);
        Debug.Log("Pause Hit ");
        Time.timeScale = 0f;
        GameIspaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale =1f;
        Debug.Log("Loading menu ..");
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game ....");
        Application.Quit();

    }
}
