using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class BombController : MonoBehaviour
{
    [Header("Bomb")]
    
    [SerializeField] GameObject bomb;
    [SerializeField] int bombsAmount = 1;
    [SerializeField] Tilemap tilemap;
    bool canLauchBomb = true;

    public void LauchBomb() {
        if (GameObject.FindGameObjectsWithTag("Bomb").Length < bombsAmount) {
            Vector3Int cell = tilemap.WorldToCell(this.transform.position); //change the world position to cell position 
            Vector3 cellCenter = tilemap.GetCellCenterWorld(cell); // get the center of the cell
            Instantiate(bomb, cellCenter, Quaternion.identity);
        }
    }
}

