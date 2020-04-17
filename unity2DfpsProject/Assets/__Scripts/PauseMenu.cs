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

    //Resume Method resumes gameplay in scene
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        //Debug to console
        Debug.Log("Resume Hit");
        Time.timeScale = 1f;
        GameIspaused = false;

    }
    //Resume Method pauses gameplay in scene
    void Pause()
    {
        
        pauseMenuUI.SetActive(true);
        //Debug to console
        Debug.Log("Pause Hit ");
        Time.timeScale = 0f;
        GameIspaused = true;
    }

    //LoadMenu Method Loads menu in scene
    public void LoadMenu()
    {
        Time.timeScale =1f;
        //Debug to console
        Debug.Log("Loading menu ..");
        SceneManager.LoadScene("Menu");
    }

    //QuitGame Method quits and exits game while playing the build
    public void QuitGame()
    {
        //Debug to console
        Debug.Log("Quitting game ....");
        Application.Quit();

    }
}
