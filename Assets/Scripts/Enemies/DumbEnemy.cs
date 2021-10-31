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
    [SerializeField] SpriteRenderer spr;
    [SerializeField] Animator anim;

    // Update is called once per frame
    void Update() {
        rb.velocity = senseOfDirection * Direction * speed * Time.deltaTime;
        // print(Mathf.Sign(rb.velocity.y));
        anim.SetFloat("yVelocity",Mathf.Sign(rb.velocity.y));
        if(rb.velocity.y != 0  && rb.velocity.x == 0) {
            anim.SetBool("hasVerticalSpeed", true);
        } else {
            anim.SetBool("hasVerticalSpeed", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag != null) {
            senseOfDirection *= -1;
            this.transform.localScale *= new Vector2(-1, 1);
        }
    }
}
