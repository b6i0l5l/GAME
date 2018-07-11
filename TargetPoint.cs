using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetPoint : MonoBehaviour {

    GameObject score;
    Text timercountdown;
    float timing;
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("scoretexttag");
        timercountdown = GetComponent<Text>();
    }
    void OnMouseDown()
    {
        if (tag == "Target1")
        {
            score.GetComponent<Score>().Scoretotal += 1;
        }

        else if(tag== "Target2")
        {
            score.GetComponent<Score>().Scoretotal += 2;
        }
        else if (tag == "Target3")
        {
            score.GetComponent<Score>().Scoretotal += 3;
        }
        else if (tag == "Target4")
        {
            score.GetComponent<Score>().Scoretotal += 4;
        }
        else if (tag == "Target5")
        {
            score.GetComponent<Score>().Scoretotal += 5;
        }
        else if (tag == "Target6")
        {
            score.GetComponent<Score>().Scoretotal += 6;
        }
        else if (tag == "Targe7")
        {
            score.GetComponent<Score>().Scoretotal += 7;
        }
        else if (tag == "Target8")
        {
            score.GetComponent<Score>().Scoretotal += 8;
        }
        else if (tag == "Target9")
        {
            score.GetComponent<Score>().Scoretotal += 9;
        }
        else if (tag == "Targetdivide2")
        {
            score.GetComponent<Score>().Scoretotal /= 2;
        }
        else if (tag == "Targetrandoom")
        {
            int num = Random.Range(1, 3);
            if (num == 1)
            { score.GetComponent<Score>().Scoretotal *= 2; }
            else if(num==2)
            {

                timing = 0;
                timercountdown.text = timing.ToString("0");
            }
        }

    }
}
