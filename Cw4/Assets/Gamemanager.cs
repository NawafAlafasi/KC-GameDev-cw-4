using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{

    public int score = 0;
    public Text text;
    public int increment = 0;
    public Text text2;
    public Text text3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void clicker()
    {
        score++;
        text.text = score.ToString();
    }

    public void store()
    {
        if(score >= 5)
        {
            text3.text = "";
            increment++;
            score -= 5;
            text2.text = "INC = " + increment;
            text.text = score.ToString();
        }
        else
        {
            text3.text = "You haven't reached the required score";
        }
        
    }

}
