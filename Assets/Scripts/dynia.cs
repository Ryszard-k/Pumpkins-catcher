using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dynia : MonoBehaviour
{
    public float speed = 0.0f;
    private Rigidbody2D rb;


    // Use this for initialization
    void Start () {
        speed = Random.Range(1.0f, 6.0f);
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
       
    }

    // Update is called once per frame
    void Update () {
        if(rb.position.y < -3.5f * 2){
            Destroy(this.gameObject);
        }
    }
}
