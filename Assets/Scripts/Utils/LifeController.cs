using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour {
    [SerializeField] int life = 1;
    private int currentLife;

    void Start() {
        currentLife = life;
    }

    public void TakeDamage(int damage) {
        currentLife -= damage;

        if (currentLife == 0) {
            Death();
        }
    }
    
    private void Death() {
        Destroy(this.gameObject);
    }
}
