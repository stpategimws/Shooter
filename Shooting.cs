using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform bullet;
    //public GameObject Spawn;
    public GameObject Player;
    public Transform player;


    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetMouseButtonDown(0))
        {
            Transform BulletInstance = (Transform)Instantiate(bullet, GameObject.Find("Spawn").transform.position, Quaternion.identity);
            BulletInstance.GetComponent<Rigidbody>().AddRelativeForce(player.forward * 5000);
        }

    }
}
