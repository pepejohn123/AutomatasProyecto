using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScript : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    public void Setup(int score){
        gameObject.SetActive(true);
        pointsText.text= score.ToString() + "POINTS";
    }

    public void RestartButton(){
        SceneManager.LoadScene("SampleScene");
    }

}
