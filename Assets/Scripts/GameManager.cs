using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button button;
    public GameObject titleScreen;
    public bool isGameActive = false;
    public GameObject CharacterScreen;
    public TextMeshProUGUI scoreText;
    public GameObject panel;
    public GameObject gameOver, heart0, heart1, heart2, heart3, heart4, heart5, heart6;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public Image overScreen;
    public static int health = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 7)
        {
            heart0.gameObject.SetActive(true);
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(true);
            heart4.gameObject.SetActive(true);
            heart5.gameObject.SetActive(true);
            heart6.gameObject.SetActive(true);
        }
        if (health == 6)
        {
            heart0.gameObject.SetActive(true);
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(true);
            heart4.gameObject.SetActive(true);
            heart5.gameObject.SetActive(true);
            heart6.gameObject.SetActive(false);
        }
        if (health == 5)
        {
            heart0.gameObject.SetActive(true);
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(true);
            heart4.gameObject.SetActive(true);
            heart5.gameObject.SetActive(false);
            heart6.gameObject.SetActive(false);
        }
        if (health == 4)
        {
            heart0.gameObject.SetActive(true);
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(true);
            heart4.gameObject.SetActive(false);
            heart5.gameObject.SetActive(false);
            heart6.gameObject.SetActive(false);
        }
        if (health == 3)
        {
            heart0.gameObject.SetActive(true);
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(false);
            heart4.gameObject.SetActive(false);
            heart5.gameObject.SetActive(false);
            heart6.gameObject.SetActive(false);
        }
        if (health == 2)
        {
            heart0.gameObject.SetActive(true);
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(false);
            heart3.gameObject.SetActive(false);
            heart4.gameObject.SetActive(false);
            heart5.gameObject.SetActive(false);
            heart6.gameObject.SetActive(false);
        }
        if (health == 1)
        {
            heart0.gameObject.SetActive(true);
            heart1.gameObject.SetActive(false);
            heart2.gameObject.SetActive(false);
            heart3.gameObject.SetActive(false);
            heart4.gameObject.SetActive(false);
            heart5.gameObject.SetActive(false);
            heart6.gameObject.SetActive(false);
        }
        if (health == 0)
        {
            heart0.gameObject.SetActive(false);
            heart1.gameObject.SetActive(false);
            heart2.gameObject.SetActive(false);
            heart3.gameObject.SetActive(false);
            heart4.gameObject.SetActive(false);
            heart5.gameObject.SetActive(false);
            heart6.gameObject.SetActive(false);
            GameOver();
        }

    }

    public void ButtonStart()
    {
        StartGame();


    }
    public void StartGame()
    {
        isGameActive = true;
        titleScreen.gameObject.SetActive(false);
        CharacterScreen.gameObject.SetActive(true);

    }
    public void pause()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
    }

    public void resume()
    {
        Time.timeScale = 1;
        panel.SetActive(false);
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        overScreen.gameObject.SetActive(true);
        health = 0;
    }
    public void RestartGame()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        health = 4;
        Time.timeScale = 1;
    }
}
