using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 8f;
    public float doubleJump = 6f;
    public float xRange = 2.7f;
    public float zRange = 0;
    public float yRange = 0;

    private Rigidbody rb;
    private bool isOnGround = true;
    private bool canDoubleJump = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        float moveInput = Input.GetAxis("Horizontal");
        Vector3 moveDirection = new Vector3(moveInput, 0f, 0f);
        transform.position += moveDirection * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))

        {
            if (isOnGround)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isOnGround = false;
                canDoubleJump = true;
            }
            else if (canDoubleJump)
            {
                rb.velocity = new Vector3(rb.velocity.x, 0f, 0f);
                rb.AddForce(Vector3.up * doubleJump, ForceMode.Impulse);
                canDoubleJump = false;
            }
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        if (transform.position.y < yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }
    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        if (collision.gameObject.CompareTag("coin"))
        {
            Destroy(collision.gameObject);
            ScoreManager.instance.AddPoint();
        }
        if (collision.gameObject.CompareTag("Evil") && GameManager.health > 0)
        {
            GameManager.health -= 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("life"))
        {
            GameManager.health += 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("PowerUp"))
        {
            Destroy(collision.gameObject);
            ScoreManager.instance.Double();

        }
    }

}
