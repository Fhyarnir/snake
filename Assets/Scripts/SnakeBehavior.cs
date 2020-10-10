using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeBehavior : MonoBehaviour
{
    public float moveSpeed = 3;
    public Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(move.x, move.y, 0) * moveSpeed * Time.deltaTime;
    }
}
