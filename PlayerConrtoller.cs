using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerConrtoller : MonoBehaviour {

    public Text invul;
    private float speed = 6.0F;
    private float timer = 5;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            gameObject.transform.position -= gameObject.transform.forward * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            gameObject.transform.position += -gameObject.transform.right * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            gameObject.transform.position += gameObject.transform.right * speed * Time.deltaTime;

        if (InvulnerabilityController.Inv==true)
        {
            timer -= Time.deltaTime;
            if (timer<=0)
            {
                InvulnerabilityController.Inv = false;
                timer = 5;
                invul.text = "";
            }
        }
    }
}
