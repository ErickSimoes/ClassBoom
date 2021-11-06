using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class BombController : MonoBehaviour
{
    [Header("Bomb")]
    
    [SerializeField] GameObject bomb;
    [SerializeField] Tilemap tilemap;
    bool canLauchBomb = true;
    float nextLauch = 0;
    [SerializeField] float cooldown = 3f;

    private void Awake() {
        tilemap = GameObject.FindGameObjectWithTag("TilemapBrick").GetComponent<Tilemap>();
    }

    private void Update() {
        tilemap = GameObject.FindGameObjectWithTag("TilemapBrick").GetComponent<Tilemap>();
        if(Time.time > nextLauch) {
            canLauchBomb = true;            
        } else {
            canLauchBomb = false;
        }
    }
    public void LauchBomb() {
        if (canLauchBomb) {
            nextLauch = Time.time + cooldown;
            Vector3Int cell = tilemap.WorldToCell(this.transform.position); //change the world position to cell position 
            Vector3 cellCenter = tilemap.GetCellCenterWorld(cell); // get the center of the cell
            Instantiate(bomb, cellCenter, Quaternion.identity);
        }
    }
}

