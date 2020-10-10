using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeBehavior : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;
    public Vector3 eulerAngles;
    public Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        // Will replace the default inside of unity, ie. 3
        moveSpeed = 10;
        rotateSpeed = 10;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D");

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "strawberry")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            // Debug.Log("Do something else here");
            moveSpeed = 100;
        }
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(move.x, move.y, 0) * moveSpeed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.eulerAngles = Vector3.forward * 0;
            move.y = 1;
            move.x = 0;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            move.y = -1;
            move.x = 0;
            transform.eulerAngles = Vector3.forward * 180;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            move.x = 1;
            move.y = 0;
            transform.eulerAngles = Vector3.forward * -90;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            move.x = -1;
            move.y = 0;
            transform.eulerAngles = Vector3.forward * 90;
        }
    }
}
