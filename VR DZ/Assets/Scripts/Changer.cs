using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour
{
    [SerializeField] private GameObject a;
    private bool b = true;

    private void Update()
    {
        a.SetActive(b);
    }

    public void Activator()
    {
        b = !b;
    }
}
