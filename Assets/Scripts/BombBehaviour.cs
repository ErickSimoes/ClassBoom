using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBehaviour : MonoBehaviour
{
    [SerializeField] float bombCoolddown = 0.5f;
    [SerializeField] LayerMask Destructable;

    [SerializeField] Collider2D[] colls;
    [SerializeField] SpriteRenderer spr;
    [SerializeField] SpriteRenderer[] chilldreenSpr;

    void Start()
    {
        foreach(Collider2D coll in colls) {
            coll.enabled = false;
        }

        foreach (SpriteRenderer sprChild in chilldreenSpr) {
            sprChild.enabled = false;
        }

        Invoke("explode", bombCoolddown);
        Invoke("endOfExplosion", bombCoolddown + 0.5f);
    }



    void explode() {
        spr.enabled = false;

        foreach(Collider2D coll in colls) {
            coll.enabled = true;
        }   

        foreach (SpriteRenderer sprChild in chilldreenSpr) {
            sprChild.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(exploded == true && other.gameObject.tag == "Player")
        other.gameObject.GetComponent<PlayerCollision>().Killed();
    }
    void endOfExplosion(){
        Destroy(this.gameObject);
    }

}
