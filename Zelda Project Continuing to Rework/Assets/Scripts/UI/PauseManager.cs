using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private bool isPaused = false;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject inventoryMenu;
    [SerializeField] private FloatValue gameSpeed;
    [SerializeField] private string menuSceneString;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Pause"))
        {
            ChangePauseValue();
        }
    }

    void ChangePauseValue()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            pauseMenu.SetActive(true);
            gameSpeed.value = 0f;
        }
        else
        {
            pauseMenu.SetActive(false);
            gameSpeed.value = 1f;
        }
    }


    public void ResumeButton()
    {
        ChangePauseValue();
    }

    public void QuitButton()
    {
        SceneManager.LoadScene(menuSceneString);
    }
}
