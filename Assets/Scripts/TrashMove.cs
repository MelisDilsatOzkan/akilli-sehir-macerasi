using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashMove : MonoBehaviour

{
    public float moveSpeed = 1f; // Hareket h�z�
    public float amplitude = 0.5f; // Hareket genli�i
    public float frequency = 1f; // Hareket frekans�

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Sin�zoidal hareket hesaplamas�
        float newY = startPos.y + Mathf.Sin(Time.time * frequency) * amplitude;

        // Yeni pozisyonu g�ncelleme
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}