using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializingScene : MonoBehaviour
{
    [SerializeField] Transform[] points;
    [SerializeField] GameObject[] playersPrefab;
    int[] playerIndexPrefab = {0,1};
    [SerializeField] GameObject[] skins;
    [SerializeField] GameObject Grid;
    [SerializeField] int playersToSpawn;

    [SerializeField] GameObject storer;
    // Start is called before the first frame update

    private void Awake() {
        storer = GameObject.FindGameObjectWithTag("Storer");
    }
    void Start() {
        playerIndexPrefab[0] = storer.GetComponent<SaveVariables>().player1SkinIndex;
        playerIndexPrefab[1] = storer.GetComponent<SaveVariables>().player2SkinIndex;
        SpawnPlayers();
    }

    public void SpawnPlayers() {
        Instantiate(Grid, new Vector2(0,-1), Quaternion.identity);
        for (int i = 0; i < playersToSpawn; i++) {
            GameObject player = Instantiate(playersPrefab[i], points[i].position, Quaternion.identity) as GameObject;
            GameObject skin = Instantiate(skins[playerIndexPrefab[i]], player.transform.position, Quaternion.identity) as GameObject;
            skin.transform.SetParent(player.transform, true);
        }
    }
}
