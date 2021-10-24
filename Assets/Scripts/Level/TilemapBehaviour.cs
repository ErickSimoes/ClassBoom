using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class TilemapBehaviour : MonoBehaviour
{
    [SerializeField] Tilemap tilemap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Explosion") {
            var tilePos = tilemap.WorldToCell(other.gameObject.transform.position);
            Debug.Log("location:" + tilePos);
            tilemap.SetTile(tilePos, null);
            tilemap.SetTile(new Vector3Int(tilePos.x, tilePos.y, tilePos.z), null);
        }
    }

    //  void OnCollisionEnter2D(Collision2D collision)
    // {
    //     Vector3 hitPosition = Vector3.zero;
    //     if (tilemap != null && tilemapGameObject == collision.gameObject)
    //     {
    //         foreach (ContactPoint2D hit in collision.contacts)
    //         {
    //             hitPosition.x = hit.point.x - 0.01f * hit.normal.x;
    //             hitPosition.y = hit.point.y - 0.01f * hit.normal.y;
    //             tilemap.SetTile(tilemap.WorldToCell(hitPosition), null);
    //         }
    //     }
    // }
}
