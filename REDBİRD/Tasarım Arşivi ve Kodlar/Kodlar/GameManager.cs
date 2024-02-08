using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public int score;
    public Text ScoreText;


    //Skoru ba�lat�yoruz
    void Start()
    {
        score = 0;
        ScoreText.text = score.ToString();
    }


    


    //Skorun artarak devam etmesini sa�l�yoruz.
    public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }

    //Oyunda �l�nd���nde yeni ba�tan ba�lamas�n� sa�l�yoruz.
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}