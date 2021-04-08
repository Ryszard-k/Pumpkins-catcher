using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployPatyki : MonoBehaviour
{
    public float respawnTime = 2.5f;
    public GameObject galaz1;
    public GameObject patyk;

    // Use this for initialization
    void Start () {
        StartCoroutine(PatykiWave());
    }

    private void spawnPatyk(){
        GameObject a = Instantiate(patyk) as GameObject;
        a.transform.position = new Vector2(Random.Range(-5f, 5f), Random.Range(2f, 3f) * 2);
    }

    private void spawnGalaz1(){
        GameObject a = Instantiate(galaz1) as GameObject;
        a.transform.position = new Vector2(Random.Range(-5f, 5f), Random.Range(2f, 3f) * 2);
    }

    IEnumerator PatykiWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnPatyk();
            spawnGalaz1();
        }
    }
}
