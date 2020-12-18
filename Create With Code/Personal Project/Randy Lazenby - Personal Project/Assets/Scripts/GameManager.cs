using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float time;
    public TextMeshProUGUI timer;
    public GameManager gameManager;
    public ParticleSystem muzzleFlash;
    public TextMeshProUGUI gameOver;
    public Button restart;
    public TextMeshProUGUI startScreen;
    public Button start;
    private bool isGameActive;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        time = 0;
        timer.text = "Time: " + time * Time.deltaTime;
        isGameActive = true;
    }

    void RunningTimer()
    {
        time++;
    }

    public void GameOver()
    {
        isGameActive = false;
        gameOver.gameObject.SetActive(true);
        restart.gameObject.SetActive(true);
        startScreen.gameObject.SetActive(false);
        start.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        startScreen.gameObject.SetActive(false);
        start.gameObject.SetActive(false);
        timer.gameObject.SetActive(true);
        RunningTimer();
        isGameActive = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        startScreen.gameObject.SetActive(true);
        start.gameObject.SetActive(true);
        timer.gameObject.SetActive(false);
        time = 0;
        StartGame();
    }

    private void OnSpaceBarDown()
    {
        Instantiate(muzzleFlash, transform.position, muzzleFlash.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        time++;
        RunningTimer();
    }

    private void LateUpdate()
    {
        timer.text = "Time: " + time * Time.deltaTime;
    }
}
