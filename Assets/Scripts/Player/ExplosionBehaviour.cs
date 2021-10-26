using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class ExplosionBehaviour : MonoBehaviour
{
    [SerializeField] private float rayRange = 2;
    [SerializeField] private int destrucLayer = 6;
    [SerializeField] private float rayPoint;

    [SerializeField] RaycastHit2D[] rays;

    private void FixedUpdate() {
        RaycastHit2D rayLeft = Physics2D.Raycast(new Vector3(transform.position.x + rayPoint, transform.position.y, transform.position.z), -Vector2.right * rayRange, destrucLayer);
        if(rayLeft) {
            explosion(rayLeft.collider.gameObject);            
        }
    }

    private void explosion(GameObject obj) {
        print(obj.tag);
        if(obj.layer == destrucLayer) {
            obj.GetComponent<LifeController>().TakeDamage(1);
        } else if(obj.tag == "DestructableBrick") {
            Tilemap tilemap = obj.GetComponent<Tilemap>();
            var tilePos = tilemap.WorldToCell(obj.transform.position);
            Debug.Log("location:" + tilePos);
            tilemap.SetTile(tilePos, null);
            tilemap.SetTile(new Vector3Int(tilePos.x, tilePos.y, tilePos.z), null);
        }
    }

    private void OnDrawGizmos() {
        Vector3 left = transform.TransformDirection(Vector2.left) * rayRange;
        Debug.DrawRay(new Vector3(transform.position.x + rayPoint, transform.position.y, transform.position.z), left, Color.green);
    }
}
