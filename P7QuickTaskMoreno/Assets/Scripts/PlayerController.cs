using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float vertical;
    float moveSpeed = 5;
    float jumpForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(Vector2.right * horizontal);
        vertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0f, jumpForce));
        }
    }
}
