using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private Text text;
    private int counter = 0;

    private void OnCollisionEnter(Collision collosion)
    {
        counter--;
        text.text = counter.ToString();
    }
}
