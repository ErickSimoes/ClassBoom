using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class PlayerBehaviour : MonoBehaviour
{
    internal Rigidbody2D rb;

    [Header("Movement")]
    [Range(100,300)]
    [SerializeField] float speed = 100;
    Vector2 direction;

    //buttons
    [SerializeField] string lauchButtonName = "Launch";

    //Childreens
    internal BombController _bombController;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        _bombController = FindObjectOfType<BombController>();
    }

    void Update()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.velocity = direction.normalized * speed * Time.fixedDeltaTime;

        //inputs
        if (Input.GetButtonDown(lauchButtonName))
            _bombController.LauchBomb();
    }
}