using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text textbox;

    public int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();

        textbox.text = "Score: 0";
    }

    void Update()
    {
        textbox.text = "Score: " + score;
    }
}
