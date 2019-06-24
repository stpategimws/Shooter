using System.Collections;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float TimeStart;
    public float TimeEnd;
    public float SpeedTime;

    /*
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
            Destroy(gameObject);
    }
    */

    void FixedUpdate()
    {
        /*
        TimeStart += SpeedTime;
        if (TimeStart >= TimeEnd)
        {
            gameObject.SetActive(false);
        }
        */
    }

}
