using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public Text textHealth;

    public static int healthPlayer;

    // Use this for initialization
    void Start()
    {
        healthPlayer = 100;
    }

    // Update is called once per frame
    void Update()
    {
        textHealth.text = "Health: " + healthPlayer;
        if (healthPlayer > 100)
            healthPlayer = 100;
        if (healthPlayer < 0)
            healthPlayer = 0;
    }
}
