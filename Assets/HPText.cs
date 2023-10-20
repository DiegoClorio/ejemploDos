using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HPText : MonoBehaviour
{
    public int hp = 3;
    TMP_Text textComponent;

    void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }

    void Update()
    {
        textComponent.text = "Vidas: " + hp;
    }
}
