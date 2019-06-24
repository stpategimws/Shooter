using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryController : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Vict;
    public GameObject Player;
    public GameObject aim;
    public GameObject ParticleSystem;

    public static int Score;

	private void Victory()
    {
        aim.SetActive(false);
        Vict.SetActive(true);
        Player.SetActive(false);
        Camera.SetActive(true);
        ParticleSystem.SetActive(true);
    }
    
    // Use this for initialization
	void Start ()
    {
        Score = 0;	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Score == 55)
            Victory();
	}
}
