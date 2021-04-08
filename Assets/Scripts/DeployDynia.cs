using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployDynia : MonoBehaviour
{
    public GameObject PrefabDynia;
    public float respawnTime = 1.0f;

    // Use this for initialization
    void Start () {
        StartCoroutine(pumpkinWave());
    }

    private void spawnDynia(){
        GameObject a = Instantiate(PrefabDynia) as GameObject;
        a.transform.position = new Vector2(Random.Range(-5f, 5f), Random.Range(2f, 3f) * 2);
    }

    IEnumerator pumpkinWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnDynia();
        }
    }
}
