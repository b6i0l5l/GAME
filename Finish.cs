using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour {

    public Text Finishscore;
    //GameObject Gettimer;
    GameObject Getscore;
	// Use this for initialization
	void Start ()
    {
        Getscore = GameObject.FindGameObjectWithTag("scoretexttag");
        
        
        Invoke("FinishUP", 2);
        
    }
	
	
    
    void FinishUP()
    {
        
        Finishscore.text = "Your score is: " + Getscore.GetComponent<Score>().Scoretotal;
       
    }
}
