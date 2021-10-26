using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {
    private LifeController _lifeController;

    private void Awake() {
        _lifeController = GetComponent<LifeController>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Explosion") {
            print("babu");
            _lifeController.TakeDamage(1);
        }
    }
}
