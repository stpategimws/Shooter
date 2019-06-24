using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public static float Speed=0.2f;
    private bool destr = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            if (destr==false)
                VictoryController.Score++;
            destr = true;
            Speed += 0.05f;
        }
    }

    // Use this for initialization
    void Start ()
    {
        Speed = 1;
	}
	
	// Update is called once per frame
	void Update ()
    {        
        if (destr==false)
        {
            if (RandomMotion.randomNumber == 1)
            {
                gameObject.transform.position += gameObject.transform.forward * Speed * Time.deltaTime;
                gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else if (RandomMotion.randomNumber == 2)
            {
                gameObject.transform.position += gameObject.transform.forward * Speed * Time.deltaTime;
                gameObject.transform.rotation = Quaternion.Euler(0, 155, 0);
            }
            else if (RandomMotion.randomNumber == 3)
            {
                gameObject.transform.position += gameObject.transform.forward * Speed * Time.deltaTime;
                gameObject.transform.rotation = Quaternion.Euler(0, 200, 0);
            }
        }
        if (destr==true)
        {
            gameObject.GetComponent<BoxCollider>().isTrigger = false;
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            Destroy(gameObject, 3f);
        }
        
    }
}
