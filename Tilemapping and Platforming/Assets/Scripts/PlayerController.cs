using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour{
private Rigidbody2D rb2d;
public float speed;
public float jumpForce;
public Text countText;

public Text livesText;

public Text loseText;

public Text winText;

private int count;

private int lives;


void Start () {
    rb2d = GetComponent<Rigidbody2D>();

    count = 0;

    winText.text = "";
    loseText.text = "";

    lives = 3;

}
void Update(){

}
void FixedUpdate()
{
    if (Input.GetKey("escape"))
     Application.Quit();

    float moveHorizontal = Input.GetAxis("Horizontal");
    Vector2 movement = new Vector2(moveHorizontal, 0);
    rb2d.AddForce(movement * speed);
{

}
}
void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.CompareTag("Pickup"))
                {
                     other.gameObject.SetActive(false);
                     count = count + 1;
                     SetCountText();
                }
                else{
                    other.gameObject.CompareTag("Enemy");
                    other.gameObject.SetActive(false);
                    lives = lives - 1;
                    SetCountText();
                }
                void SetCountText()
                {
livesText.text = "Lives:" + lives.ToString();
if (lives <= 0)
loseText.text = "You Lose!";

countText.text = "Count:" + count.ToString();
if (count >= 4)
winText.text = "You Win!";
                }
                
              
}
void OnCollisionStay2D(Collision2D collision)
{
    if(collision.collider.tag == "Ground"){
if(Input.GetKey(KeyCode.UpArrow)){
    rb2d.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
}

{
}
    }
}
}