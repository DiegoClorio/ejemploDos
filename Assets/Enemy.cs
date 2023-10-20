using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    PointsText pointsScript;
    HPText hpScript;

    private void Start()
    {
        pointsScript = FindObjectOfType<PointsText>();
        hpScript = FindObjectOfType<HPText>();
    }

    private void Update()
    {
        transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Jugador")
        {
            hpScript.hp = hpScript.hp - 1;

            if (hpScript.hp == 0)
            {
                Destroy(collision.gameObject);
            }

            Destroy(gameObject);
        }
        else
        {
            pointsScript.puntos = pointsScript.puntos + 1;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
