using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int hp = 100;
    public float betweenshots = .6f;

    public GameObject shooty;
    public Transform bulletshowup;

    public float lastshoot;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            hp = hp - 50;
            Debug.Log("ouch -50");
        }
        if (collision.gameObject.tag == "met")
        {
            hp = hp - 10;
            Debug.Log("ouch -10");
        }

        if (collision.gameObject.tag == "bulletE")
        {
            hp = hp - 10;
            Debug.Log("ouch -10");
        }


        if (hp <= 0)
        {
            Debug.Log("Game Over");
            Destroy(this.gameObject);
        }

    }
   private void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Time.time > lastshoot + betweenshots)
            shoot();
        } 
          
    }

    private void shoot()
    {
        Instantiate(shooty, bulletshowup.position, Quaternion.identity); ;

        lastshoot = Time.time; 
    }
}
