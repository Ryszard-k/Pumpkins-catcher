using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployKonar : MonoBehaviour
{
    public GameObject Konar;
    public float respawnTime = 0.65f;

    // Use this for initialization
    void Start () {
        StartCoroutine(konarWave());
    }

    private void spawnKonar(){
        GameObject a = Instantiate(Konar) as GameObject;
        a.transform.position = new Vector2(Random.Range(-5f, 5f), Random.Range(2f, 3f) * 2);
    }

    IEnumerator konarWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnKonar();
        }
    }
}
