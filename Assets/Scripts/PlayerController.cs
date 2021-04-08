using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
	public float speed = 10f;
    private Rigidbody2D rb;
    public Vector2 movement;
    private AudioSource audio;
    public float dash = 100f;
    public TextMeshProUGUI loose;
    public Button exit;
    public Button play_again;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
        exit.gameObject.SetActive(false);
        play_again.gameObject.SetActive(false);
        loose.enabled = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        speed = 5f;  

        if(rb.position.y < -5f){
            Destroy(this.gameObject);
            Time.timeScale = 0;
            loose.enabled = true;
            exit.gameObject.SetActive(true);
            play_again.gameObject.SetActive(true);
        }

        if (Input.GetKey("escape"))
		{
			Debug.Log("quit");
			Application.Quit();
		}  
    }
	
	void FixedUpdate(){
        movePlayer(movement);
    }
    void movePlayer(Vector2 direction){
        rb.velocity = direction * speed;
        if(Input.GetKey("space")){
            rb.AddForce(direction * speed * dash);
        }      
    }
	
    private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("pumpkins")){
            audio.Play();
			Destroy(other.gameObject);
		}
	}

}
