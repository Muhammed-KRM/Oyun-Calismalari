using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Birdy BirdScript;
    public GameObject Borular;
    public float height;
    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    //Ku�umuz herhangi bir yere de�medi�i s�rece gelen borular belli bir y�kseklik de�eri aral���nda de�i�erek gelsin.
    public IEnumerator SpawnObject(float time)
    {
        while(!BirdScript.isDead) 
        {
           
            Instantiate(Borular, new Vector3(3, Random.Range(-height, height), 0),Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
       
    }
}
