using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boru : MonoBehaviour
{

    public float speed;


    //Borular platformu geçtikten 9 saniye sonra yok olur.
    private void Start()
    {
        Destroy(gameObject, 9);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
