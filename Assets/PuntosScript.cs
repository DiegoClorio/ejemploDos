using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntosScript : MonoBehaviour
{
    private TMP_Text textComponent;
    private int puntos = 0;

    private void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }

    void Update()
    {
        textComponent.text = "Puntos: " + puntos;
    }

    public void AddPoints(int value)
    {
        puntos = puntos + value;
    }
}
