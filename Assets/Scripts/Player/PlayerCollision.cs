using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    private LifeController _lifeController;

    private SceneCaller _sceneCaller;
    private void Awake() {
        _lifeController = GetComponent<LifeController>();
        _sceneCaller = FindObjectOfType<SceneCaller>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        // if(other.gameObject.tag == "Explosion") {
        //     _lifeController.TakeDamage(1);
        // }
        switch (other.gameObject.tag) {
            case "Explosion": _lifeController.TakeDamage(1); break;
            case "WinDoor": _sceneCaller.CallScene("WinGame"); break;
            default: break;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Enemy") {
            _lifeController.TakeDamage(1);
        }
    }
}
