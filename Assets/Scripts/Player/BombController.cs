using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    [Header("Bomb")]
    
    [SerializeField] GameObject bomb;
    [SerializeField] int bombsAmount = 1;
    bool canLauchBomb = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LauchBomb()
    {
        if (GameObject.FindGameObjectsWithTag("Bomb").Length < bombsAmount)
        {
            Instantiate(bomb, this.transform.position, Quaternion.identity);
        }
    }
}

