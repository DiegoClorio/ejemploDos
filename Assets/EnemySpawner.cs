using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float  max;
    public float min;

    private float timer = 1;
    void Start()
    {
        
    }

    void Update()
    {

        timer = timer - Time.deltaTime;

        if (timer <= 0)
        {
            float posY = Random.Range(min, max);
            Instantiate(enemyPrefab, new Vector3(transform.position.x, posY, 0), Quaternion.identity);
            timer = 1;
        }
    }
}
