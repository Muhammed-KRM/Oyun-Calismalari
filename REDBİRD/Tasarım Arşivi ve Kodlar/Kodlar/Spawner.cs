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

    //Kuþumuz herhangi bir yere deðmediði sürece gelen borular belli bir yükseklik deðeri aralýðýnda deðiþerek gelsin.
    public IEnumerator SpawnObject(float time)
    {
        while(!BirdScript.isDead) 
        {
           
            Instantiate(Borular, new Vector3(3, Random.Range(-height, height), 0),Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
       
    }
}
