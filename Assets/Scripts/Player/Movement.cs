using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody;
    [SerializeField] float speed;

    void Update()
    {
        var inputX = Input.GetAxis("Horizontal");
        var inputY = Input.GetAxis("Vertical");

        Move(inputX, inputY);
    }

    void Move(float inputX, float inputY)
    {
        rigidbody.velocity = new Vector3(inputX, inputY) * speed;
    }
}
