using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float timing;
    Text timercountdown;
	void Start () {
        timercountdown = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (timing > 0)
        {
            timing = timing - Time.deltaTime;
            timercountdown.text = timing.ToString("0");
        }
        
	}
}
