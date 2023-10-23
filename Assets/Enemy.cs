using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private PuntosScript puntosScript;

    private void Start()
    {
        puntosScript = FindObjectOfType<PuntosScript>();
    }

    private void Update()
    {
        transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {

        puntosScript.AddPoints(1);
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
