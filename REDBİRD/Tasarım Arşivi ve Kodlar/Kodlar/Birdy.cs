using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Burada ku�un hareketlerini kontrol eden kodlar bulunmakta.
public class Birdy : MonoBehaviour
{
    //Kodlamada kullanaca��m�z atamalar. 
    public bool isDead;

    public float velocity = 1f;//S��rama de�eri.
    public Rigidbody2D rb2D; 
    public GameManager managerGame;
    public GameObject DeathScreen;


    private void Start()
    {
        Time.timeScale = 1;
    }
    

    //Ku�un z�plamas�n� mouse sa� t�k�na at�yoruz.
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb2D.velocity = Vector2.up * velocity;
        }
    }

    //Skor sayac� olu�turuyoruz. 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name=="ScoreArea")
        {
            managerGame.UpdateScore();
        }
    }

    //Burada herhangi bir yere �arpt���nda �ls�n ve oyun dursun istiyoruz.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;

            DeathScreen.SetActive(true);
        }
    }

}
