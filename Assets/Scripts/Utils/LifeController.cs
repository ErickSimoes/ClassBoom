using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour {
    [SerializeField] int life = 1;
    private int currentLife;
    [SerializeField] private bool isPlayer;
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
        if(isPlayer) {
            FindObjectOfType<SceneCaller>().CallScene("GameOver");
        }
    }
}
