using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LayGrid : MonoBehaviour {

   public GameObject tilePrefab;
   public List <GameObject> tileHold = new List<GameObject> ();
   [SerializeField] Transform gridParent;
   public int xTiles;
   public int yTiles;
   public float tileWidth; public float tileHeight;

   [SerializeField] float parentX, parentY;
   void Start () {
      LayTiles();
   }

   private void Update() {
             gridParent.position = new Vector3(parentX , parentY, 0);

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
               if(i == 5){
                  GameObject tile = Instantiate (tilePrefab, new Vector2 (transform.position.x + offsetX, transform.position.y - offsetY),
                  transform.rotation) as GameObject;
                  tile.transform.SetParent(gridParent);
                  tileHold.Add (tile);
              }
          }
       }
    }
   // void LayTiles() {
   //    GameObject tile = Instantiate (tilePrefab, new Vector2 (transform.position.x + offsetX, transform.position.y - offsetY),
   //    transform.rotation) as GameObject;
   // }
} 