using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Burada kuþun hareketlerini kontrol eden kodlar bulunmakta.
public class Birdy : MonoBehaviour
{
    //Kodlamada kullanacaðýmýz atamalar. 
    public bool isDead;

    public float velocity = 1f;//Sýçrama deðeri.
    public Rigidbody2D rb2D; 
    public GameManager managerGame;
    public GameObject DeathScreen;


    private void Start()
    {
        Time.timeScale = 1;
    }
    

    //Kuþun zýplamasýný mouse sað týkýna atýyoruz.
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb2D.velocity = Vector2.up * velocity;
        }
    }

    //Skor sayacý oluþturuyoruz. 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name=="ScoreArea")
        {
            managerGame.UpdateScore();
        }
    }

    //Burada herhangi bir yere çarptýðýnda ölsün ve oyun dursun istiyoruz.
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
