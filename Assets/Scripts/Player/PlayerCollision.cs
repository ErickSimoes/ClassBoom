using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Explosion") {
            Killed();
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Enemy") {
            Killed();
        }
    }

    private void Killed() {
        Destroy(this.gameObject);
    }

}
