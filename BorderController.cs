using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderController : MonoBehaviour
{
    public static bool defeat;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Enemy")
            defeat = true;
    }

    // Use this for initialization
    void Start ()
    {
        defeat = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
