using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private float spawnRate = 1.0f;
    private int score;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;

    public Button restartButton;
    public Button resumeButton;

    public GameObject titleScreen;
    public GameObject resumeScreen;

    //public AudioSource backgroundMusic;

    private Coroutine spawnCoroutine;
    public bool isGameActive;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isGameActive)
        {
            PauseGame();
        }
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            if (isGameActive)
            {
                int index = Random.Range(0, targets.Count);
                Instantiate(targets[index]);
            }

            yield return new WaitForSecondsRealtime(spawnRate);
        }
    }


    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;

    }

    public void GameOver()
    {
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);

        if (spawnCoroutine != null)
        {
            StopCoroutine(spawnCoroutine);
            spawnCoroutine = null;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void PauseGame()
    {
        isGameActive = false;
        Time.timeScale = 0;
        resumeScreen.SetActive(true);
        resumeButton.gameObject.SetActive(true);
    }


    public void ResumeGame()
    {
        isGameActive = true;
        Time.timeScale = 1;
        resumeScreen.SetActive(false);
        resumeButton.gameObject.SetActive(false);

        if (spawnCoroutine == null)
        {
            spawnCoroutine = StartCoroutine(SpawnTarget());
        }
    }



    public void StartGame(int difficulty)
    {
        isGameActive = true;
        spawnRate /= difficulty;

        if (spawnCoroutine == null)
        {
            spawnCoroutine = StartCoroutine(SpawnTarget());
        }

        UpdateScore(0);
        titleScreen.SetActive(false);
    }

}
