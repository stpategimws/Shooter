using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOverController : MonoBehaviour
{
    public GameObject Camera;
    public GameObject GameOver;
    public GameObject Player;
    public GameObject aim;
    private bool paused;

	private void gameOver()
    {
        GameOver.SetActive(true);
        Player.SetActive(false);
        Time.timeScale = 0;
        paused = true;
        Camera.SetActive(true);
        aim.SetActive(false);
    }
    
    // Use this for initialization
	void Start ()
    {
        Camera.SetActive(false);
        GameOver.SetActive(false);
        Time.timeScale = 1;
        paused = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if ((HealthController.healthPlayer <= 0)||(BorderController.defeat==true))
            gameOver();

    }
}
