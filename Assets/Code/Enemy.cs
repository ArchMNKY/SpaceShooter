using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float timeshoot = 10f;
    public float nextshoot;
    public GameObject bulletnemy;
    public Transform bulletshowup;

    public float enemyHP = 100;

    private Rigidbody2D rb;
    public float speed = 5f;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
           
        if (collision.gameObject.tag == "bulletP")
        {
            enemyHP = enemyHP - 10;
            Debug.Log("kill it");
        }
        if (enemyHP <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void Update()
    {
        if (Time.time > timeshoot + nextshoot)
            shoot();
        
    }

    private void shoot()
    {
        Instantiate(bulletnemy, bulletshowup.position, Quaternion.identity); ;
        nextshoot = Time.time;
    }
}
