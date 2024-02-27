 using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody body;
    public float jumpForce = 10;
    public float jumpInterval = 0.5f;
    private float jumpCooldown = 0;
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }
   
    // Update is called once per frame
    void Update()
    {
        jumpCooldown -= Time.deltaTime;
        bool canJump = jumpCooldown <= 0;

        if(canJump) {
            bool isPressingSpace = Input.GetKey(KeyCode.Space);
            if(isPressingSpace) {     
                Jump();
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        bool isSensor = other.gameObject.CompareTag("Sensor");

        if(isSensor) {
            Debug.Log("PONTOSSSSSSSSSS");
        }
    }
    private void Jump() {
        jumpCooldown = jumpInterval;
        body.velocity = Vector3.zero;
        body.AddForce(new Vector3(0,jumpForce,0), ForceMode.Impulse);
    }
}
