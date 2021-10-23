using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LayGrid : MonoBehaviour {

   public GameObject tilePrefab;
   public List <GameObject> tileHold = new List<GameObject> ();

   public int xTiles;
   public int yTiles;
   public float tileWidth; public float tileHeight;

   void Start () {
      LayTiles();
   }

   void LayTiles() {
       float offsetX = 0;
       float offsetY = 0;
       for (int i = 0; i < yTiles; i++) {
          offsetY += tileHeight;
          offsetX = 0;
          
          for (int j = 0; j < xTiles + 1; j++) {
              if (j > 0) {
                 offsetX += tileWidth;
              }
               if(i == 0 || j== 0 || i == yTiles - 1  || j == xTiles){
              GameObject tile = Instantiate (tilePrefab, new Vector2 (transform.position.x + offsetX, transform.position.y - offsetY),
              transform.rotation) as GameObject;
              tileHold.Add (tile);
              }
          }
       }
    }
} 