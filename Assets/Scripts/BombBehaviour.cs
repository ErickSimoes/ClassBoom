using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBehaviour : MonoBehaviour
{
    [SerializeField] float bombCoolddown = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("explode", bombCoolddown);
    }

    void explode() {
        Destroy(this.gameObject);
    }
}
