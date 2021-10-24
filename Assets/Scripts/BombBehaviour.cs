using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBehaviour : MonoBehaviour
{
    [SerializeField] float bombCoolddown = 0.5f;
    [SerializeField] LayerMask Destructable;
    bool exploded = false;
    [SerializeField] SpriteRenderer spr;
    [SerializeField] GameObject explosionGameObject;
	
    void Start()
    {
        explosionGameObject.SetActive(false);

        Invoke("explode", bombCoolddown);
        Invoke("endOfExplosion", bombCoolddown + 0.5f);
    }



    void explode() {
        exploded = true;
        if(exploded) {
            explosionGameObject.SetActive(true);
        }
    }

    void endOfExplosion(){
        Destroy(this.gameObject);
    }

}
