using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnrate = 1f;
    public float lastspawn;

    private void Spawn()
    {
        Vector3 position = new Vector2(0f, 0f);
        position.x = Random.Range(-4f, 4f);
        position.y = 5.7f;

        lastspawn = Time.time;
        Instantiate(prefab, position, Quaternion.identity);
        Destroy(prefab, 20f);
    }

    void Update()
    {
       
       if (Time.time > spawnrate + lastspawn)
        {
            Spawn();

        } 
       

    }

}
