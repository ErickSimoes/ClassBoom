using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializingScene : MonoBehaviour
{
    [SerializeField] Transform[] points;
    [SerializeField] GameObject[] playersPrefab;
    [SerializeField] int playersToSpawn;
    // Start is called before the first frame update
    void Start() {
        SpawnPlayers();
    }

    private void SpawnPlayers() {
        for (int i = 0; i < playersToSpawn; i++) {
            GameObject player = Instantiate(playersPrefab[i], points[i].position, Quaternion.identity) as GameObject;
        }
    }
}
