using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public GameObject Level_1;
    public GameObject Level_2;
    private int levels;


	// Use this for initialization
	void Start ()
    {
        levels = Random.Range(1, 3);
        if (levels==1)
        {
            Level_1.SetActive(true);
            Level_2.SetActive(false);
        }
        else if (levels==2)
        {
            Level_1.SetActive(false);
            Level_2.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        	
	}
}
