using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public GameObject Panel;

    public bool paused;

    public void ContinueGame()
    {
        Panel.SetActive(false);
        Time.timeScale = 1;
        paused = false;
    }

    public void NewGame()
    {
        Time.timeScale = 1;
        paused = false;
        SceneManager.LoadScene(1);
    }

    public void ExitMainMenu()
    {
        Time.timeScale = 1;
        paused = false;
        SceneManager.LoadScene(0);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Panel.activeSelf==false)
            {
                Panel.SetActive(true);
                Time.timeScale = 0;
                paused = true;
            }
            else if (Panel.activeSelf==true)
            {
                Panel.SetActive(false);
                Time.timeScale = 1;
                paused = false;
            }
        }
	}
}
