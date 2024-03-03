 using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 
    private Rigidbody2D body;
    public float jumpForce = 10;
    public float jumpInterval = 0.5f;
    private float jumpCooldown = 0;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
   
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other)
    {
        var obstacle = other.gameObject;
        if(obstacle) {
            GameManager.Instance.gameOver = true;
        }
    }
    void Update()
    {
        var gameManager = GameManager.Instance;
        if(gameManager.isGameOver()) return;

        
        jumpCooldown -= Time.deltaTime;
        bool canJump = jumpCooldown <= 0;

        if(canJump) {
            bool isPressingSpace = Input.GetKey(KeyCode.Space);
            if(isPressingSpace) {     
                Jump();
            }
        }
    }

    private void Jump() {
        jumpCooldown = jumpInterval;
        body.velocity = Vector2.zero;
        body.AddForce(new Vector2(0,jumpForce), ForceMode2D.Impulse);
    }
}
