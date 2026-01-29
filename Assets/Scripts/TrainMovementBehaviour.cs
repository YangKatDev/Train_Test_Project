using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TrainMovementBehaviour : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;

    public static Action OnAddsTime;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bee")
        {
            OnAddsTime?.Invoke();
        }
    }
}