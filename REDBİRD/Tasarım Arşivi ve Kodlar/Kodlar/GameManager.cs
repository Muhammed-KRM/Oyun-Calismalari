using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public int score;
    public Text ScoreText;


    //Skoru başlatıyoruz
    void Start()
    {
        score = 0;
        ScoreText.text = score.ToString();
    }


    


    //Skorun artarak devam etmesini sağlıyoruz.
    public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }

    //Oyunda ölündüğünde yeni baştan başlamasını sağlıyoruz.
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}