using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed  =  5f;

    private Rigidbody2D rb;

    float x;
    float y;

    float bottomLimit;
    float topLimit;
    float leftLimit;
    float rightLimit;
   
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector3 bottomLeft = Camera.main.ViewportToWorldPoint(Vector3.zero);
        bottomLimit = bottomLeft.y;
        leftLimit = bottomLeft.x;

        Vector3 topRight = Camera.main.ViewportToWorldPoint(Vector3.one);
        topLimit = topRight.y;
        rightLimit = topRight.x;


    }

    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");


    }

    private void FixedUpdate()
    {
        //Vector3 bottomLeft = Camera.main.ViewportToWorldPoint(Vector3.zero);
        //Vector3 topRight = Camera.main.ViewportToWorldPoint(Vector3.one);
       Vector3 desirePosition = transform.position + new Vector3(x, y, 0f) * speed * Time.deltaTime;

        desirePosition.x = Mathf.Clamp(desirePosition.x, leftLimit, rightLimit);
        desirePosition.y = Mathf.Clamp(desirePosition.y, topLimit, bottomLimit);

        rb.MovePosition(desirePosition);
    }

}


