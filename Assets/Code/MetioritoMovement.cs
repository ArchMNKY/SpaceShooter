using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetioritoMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;
    public GameObject particlePrefab;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(particlePrefab, transform.position, transform.rotation);
        Destroy(particlePrefab, 2F);
        Destroy(this.gameObject);
    }
}
