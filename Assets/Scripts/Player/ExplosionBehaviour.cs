using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class ExplosionBehaviour : MonoBehaviour
{
    [SerializeField] private float rayRange = 2f;
    [SerializeField] private LayerMask layerMask;
    private RaycastHit2D rayUp,rayRight, rayDown, rayLeft;
    [SerializeField] Vector2[] raysDirection;
    
    private void FixedUpdate() {
        RaycastHit2D rayUp = Physics2D.Raycast(transform.position, raysDirection[0], rayRange, layerMask, 0);
        RaycastHit2D rayRight = Physics2D.Raycast(transform.position, raysDirection[1], rayRange, layerMask, 0);
        RaycastHit2D rayDown = Physics2D.Raycast(transform.position, raysDirection[2], rayRange, layerMask, 0);
        RaycastHit2D rayLeft = Physics2D.Raycast(transform.position, raysDirection[3], rayRange, layerMask, 0);
        
        if(rayLeft.collider != null) 
            explosionOfCreatures(rayLeft.collider.gameObject);
        if(rayUp.collider != null) 
            explosionOfCreatures(rayUp.collider.gameObject);
        if(rayDown.collider != null) 
            explosionOfCreatures(rayDown.collider.gameObject);
        if(rayRight.collider != null) {
            explosionOfCreatures(rayRight.collider.gameObject);  
        } 
            
    }

    private void explosionOfCreatures(GameObject obj) {
        print(obj.tag);
        if(obj.layer == 6) {
            obj.GetComponent<LifeController>().TakeDamage(1);
        }
    }

    private void OnDrawGizmos() {
        Vector3 up = transform.TransformDirection(raysDirection[0]) * rayRange;
        Debug.DrawRay(transform.position, up, Color.red);
        Vector3 right = transform.TransformDirection(raysDirection[1]) * rayRange;
        Debug.DrawRay(transform.position, right, Color.blue);
        Vector3 down = transform.TransformDirection(raysDirection[2]) * rayRange;
        Debug.DrawRay(transform.position, down, Color.yellow);
        Vector3 left = transform.TransformDirection(raysDirection[3]) * rayRange;
        Debug.DrawRay(transform.position, left, Color.green);
    }
}
