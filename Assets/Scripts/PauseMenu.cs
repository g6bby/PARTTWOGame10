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
    public GameObject notecheckmark2;
    public GameObject notecheckmark3;
    public GameObject notecheckmark4;
    public GameObject notecheckmark5;

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

    public NoteCollider noteCollider;
    

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

            if (notecollider1 == false)
            {
                notecheckmark1.SetActive(true);
            }
        }

        if (!collider2.activeSelf)
        {
            notecollider2 = false;

            if (notecollider2 == false)
            {
                notecheckmark2.SetActive(true);
            }
        }

        if (!collider3.activeSelf)
        {
            notecollider3 = false;

            if (notecollider3 == false)
            {
                notecheckmark3.SetActive(true);
            }
        }

        if (!collider4.activeSelf)
        {
            notecollider4 = false;

            if (notecollider4 == false)
            {
                notecheckmark4.SetActive(true);
            }
        }

        if (!collider5.activeSelf)
        {
            notecollider5 = false;

            if (notecollider5 == false)
            {
                notecheckmark5.SetActive(true);
            }
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
        noteCollider.ResetCounter();
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
