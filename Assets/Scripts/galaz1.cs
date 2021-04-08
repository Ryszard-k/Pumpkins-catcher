using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class galaz1 : MonoBehaviour
{
    public float speed = 0.0f;
    private Rigidbody2D rb;


    // Use this for initialization
    void Start () {
        speed = Random.Range(2.0f, 3.0f);
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
       
    }

    void Update () {
        if(rb.position.y < -3.5f * 2){
            Destroy(this.gameObject);
        }
    }
}
