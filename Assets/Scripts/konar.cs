using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class konar : MonoBehaviour
{
    public float speed = 0.0f;
    private Rigidbody2D rb;


    // Use this for initialization
    void Start () {
        speed = Random.Range(3.0f, 4.0f);
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
       
    }

    void Update () {
        if(rb.position.y < -3.5f * 2){
            Destroy(this.gameObject);
        }
    }
}
