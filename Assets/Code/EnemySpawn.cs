using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    public float spawnrate = 1f;
    public float lastspawn;
    int g;
    private void Spawn()
    {
        g = Random.Range(1, 10);
        Vector3 position = new Vector2(0f, 0f);
        position.x = Random.Range(-4f, 4f);
        position.y = 5.7f;

        lastspawn = Time.time;
        if (g < 5)
        Instantiate(prefab1, position, Quaternion.identity);
        if (g > 5)
        Instantiate(prefab2, position, Quaternion.identity);
    }

    void Update()
    {

        if (Time.time > spawnrate + lastspawn)
        {
            Spawn();
        }


    }
}
