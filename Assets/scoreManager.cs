using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class scoreManager : MonoBehaviour
{

    public TextMeshProUGUI   scoreText;

    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score:\n"+score.ToString() + " POINTS";

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:\n"+score.ToString() + " POINTS";
    }
}
