using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3 (horizontal, 0f, vertical).normalized;
        Vector3 velocity = direction * speed;

        transform.Translate(velocity * Time.deltaTime);
    }
}
