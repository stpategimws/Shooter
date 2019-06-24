using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMotion : MonoBehaviour
{
    public static int randomNumber;
    private float timer = 3f;
	
    // Use this for initialization
	void Start ()
    {
        randomNumber = Random.Range(1, 4);
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;
        if (timer<=0)
        {
            timer = 3f;
            randomNumber = Random.Range(1, 4);
            
        }
	}
}
