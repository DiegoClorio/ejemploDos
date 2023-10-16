using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float speed;
    private Vector3 spawnPoint = new Vector3(0, 0, 0);

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up.normalized * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down.normalized * speed * Time.deltaTime);
        }
    }
}
