using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject noteMenuUI;

    public GameObject notecheckmark1;

    private AudioListener audioListener;

    public GameObject collider1;
    public GameObject collider2;
    public GameObject collider3;
    public GameObject collider4;
    public GameObject collider5;

    private bool notecollider1 = true;
    private bool notecollider2 = true;
    private bool notecollider3 = true;
    private bool notecollider4 = true;
    private bool notecollider5 = true;
    

    void Start()
    {
        audioListener = Camera.main.GetComponent<AudioListener>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Resume();
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Pause();
            }
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            NoteMenu();        
        }

        if (!collider1.activeSelf)
        {
            notecollider1 = false;
        }

        if (notecollider1 == false)
        {
            notecheckmark1.SetActive(true);
        }

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

        AudioListener.pause = false;
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

        AudioListener.pause = true;
    }

    public void RestartTheGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void NoteMenu()
    {
        noteMenuUI.SetActive(!noteMenuUI.activeSelf);
        GameIsPaused = noteMenuUI.activeSelf;
        AudioListener.pause = false;
    }
}
