using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class DumbEnemy : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private Vector2 Direction;
    private float senseOfDirection = 1;


    // Update is called once per frame
    void Update() {
        rb.velocity = senseOfDirection * Direction * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag != "Enemy") {
            print("colidiu");
            senseOfDirection *= -1;
        }
    }
}
