using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class scoreManager : MonoBehaviour
{

    public TextMeshProUGUI   scoreText;

    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = scoreText.text+score.ToString() + " POINTS";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
