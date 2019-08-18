using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    [SerializeField] private GameObject creditsPanel;
    [SerializeField] private GameObject gamePanel;
    [SerializeField] private string levelToLoad;
    [SerializeField] private VectorValue playerPosition;
    [SerializeField] private Vector2 playerPos;

    public void Play()
    {
        playerPosition.value = playerPos;
        SceneManager.LoadScene(levelToLoad);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Credits()
    {
        creditsPanel.SetActive(true);
        gamePanel.SetActive(false);
    }

    public void Back()
    {
        creditsPanel.SetActive(false);
        gamePanel.SetActive(true);
    }
}
