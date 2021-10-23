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
    Vector2 movingInputs;

    [SerializeField] Animator anim;
    [SerializeField] SpriteRenderer graphic;

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
        movingInputs.x = Input.GetAxisRaw("Horizontal");
        movingInputs.y = Input.GetAxisRaw("Vertical");

        if (movingInputs.x > 0) {
            graphic.flipX = false;
        } else if(movingInputs.x < 1) {
            graphic.flipX = true;
        }

        print("velocidade x : " + movingInputs.x + "  velocidade y : " + movingInputs.y + "  movement : " + movingInputs.SqrMagnitude());

        //animation
        anim.SetFloat("xVelocity", Mathf.Abs(movingInputs.x));
        anim.SetFloat("yVelocity", movingInputs.y);
        anim.SetFloat("speed", movingInputs.SqrMagnitude());

        direction = movingInputs;
        rb.velocity = direction.normalized * speed * Time.fixedDeltaTime;

        //inputs
        if (Input.GetButtonDown(lauchButtonName))
            _bombController.LauchBomb();
    }
}
