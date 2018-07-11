using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManeger : MonoBehaviour {

    public GameObject GetFinish;
    GameObject GetTimer;
    void Start()
    {
       
        GetTimer = GameObject.FindGameObjectWithTag("TimeCountDown");
        
    }
    
    void Update()
    {
        if (GetTimer.GetComponent<Text>().text == "0")
        { GetFinish.SetActive(true); }
    }


}
