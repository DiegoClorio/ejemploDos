using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public Transform max;
    public Transform min;

    private Vector3 spawnPos;
    void Start()
    {
        
    }

    void Update()
    {
        spawnPos = new Vector3(max.position.x, Random.Range(min.position.y, max.position.y), 0);
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}
