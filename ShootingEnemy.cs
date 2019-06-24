using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    public Transform amm;
    public GameObject point;
    public int speedAmm = 800;
    public GameObject Player;
    public float timer;

    Random randomDirection = new Random();
    private int RandomNumber;

    // Use this for initialization
    void Start()
    {
        RandomNumber = Random.Range(0, 4);
        StartCoroutine(Inst());
    }

    IEnumerator Inst()
    {
        yield return new WaitForSeconds(2);
        if (RandomNumber==1)
        {
            Transform g = (Transform)Instantiate(amm, transform.position, transform.rotation);
            g.GetComponent<Rigidbody>().AddForce(transform.forward * speedAmm);
            Destroy(g.gameObject, 3f);
        }
        Repeat();
    }

    void Repeat()
    {
        RandomNumber = Random.Range(0, 4);
        StartCoroutine(Inst());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
