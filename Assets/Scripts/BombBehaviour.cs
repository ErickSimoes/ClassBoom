using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBehaviour : MonoBehaviour
{
    [SerializeField] float bombCoolddown = 0.5f;
    [SerializeField] float triggerCooldown = 0.6f;
    [SerializeField] LayerMask Destructable;
    bool exploded = false;
    [SerializeField] SpriteRenderer spr;
    [SerializeField] GameObject explosionGameObject;

    [SerializeField] Collider2D coll;
	
    private TilemapBehaviour _tilemap;

    private void Awake() {
        _tilemap = FindObjectOfType<TilemapBehaviour>();
    }

    void Start(){
        explosionGameObject.SetActive(false);

        Invoke("explode", bombCoolddown);
        Invoke("DisableTrigger", triggerCooldown);
        Invoke("endOfExplosion", bombCoolddown + 0.5f);
    }

    

    void explode() {
        exploded = true;
        if(exploded) {
            explosionGameObject.SetActive(true);
            _tilemap.Explode(this.transform.position);  
        }
    }

    void endOfExplosion(){
        foreach (GameObject explosion in GameObject.FindGameObjectsWithTag("Explosion")) {
            Destroy(explosion);
        }
        Destroy(this.gameObject);
    }

    void DisableTrigger() {
        coll.enabled = true;
    }

}
