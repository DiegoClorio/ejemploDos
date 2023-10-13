using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedDestructora : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);

        Random.Range(1, 2);
    }
}