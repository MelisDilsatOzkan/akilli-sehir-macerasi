using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashMove : MonoBehaviour

{
    public float moveSpeed = 1f; // Hareket hýzý
    public float amplitude = 0.5f; // Hareket genliði
    public float frequency = 1f; // Hareket frekansý

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Sinüzoidal hareket hesaplamasý
        float newY = startPos.y + Mathf.Sin(Time.time * frequency) * amplitude;

        // Yeni pozisyonu güncelleme
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}