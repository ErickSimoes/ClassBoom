using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class GameRules : MonoBehaviour
{
    int totalOfEnemies;
    [SerializeField] private string enemyTag;
    [SerializeField] GameObject winDoor;
    [SerializeField] Tilemap tilemap;
    [SerializeField] Vector2 limitX, limitY;
    private Vector3 randomPos;
    private int winDoorInstantiate = 0;

    void Update() {
        totalOfEnemies = GameObject.FindGameObjectsWithTag(enemyTag).Length;
        if(totalOfEnemies <= 0)
            CreateDoor();
    }

    void CreateDoor() {
        if(winDoorInstantiate < 1) {
            randomPos.x = Random.Range(limitX.x, limitX.y);
            randomPos.y = Random.Range(limitY.x, limitY.y);
            Vector3Int cell = tilemap.WorldToCell(randomPos);
            Tile tile = tilemap.GetTile<Tile>(cell);

            if (tile == destructibleTile) {
			    Vector3 CenterOfCell = tilemap.GetCellCenterWorld(cell);
                Instantiate(winDoor, CenterOfCell, Quaternion.identity); 
                winDoorInstantiate++;
		    }
            // Vector3 CenterOfCell = tilemap.GetCellCenterWorld(cell);
            // Instantiate(winDoor, CenterOfCell, Quaternion.identity); 
            // winDoorInstantiate++;
        }
    }
}
