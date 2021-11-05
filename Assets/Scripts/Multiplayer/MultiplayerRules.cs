using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MultiplayerRules : MonoBehaviour
{
    [SerializeField] InitializingScene _initializingScene;
    [SerializeField] SceneCaller _sceneCaller;
    int p1Score = 0;
    int p2Score = 0;
    [SerializeField] TMP_Text p1Text, p2Text;
    [SerializeField] float timeToRespawn;
    bool canLockCoroutine = false;
    void Update() {
        if(GameObject.FindGameObjectsWithTag("Player").Length <= 0) {
            StartCoroutine(UpdateScore(p2Score, p2Text, "Player2"));
        } else if(GameObject.FindGameObjectsWithTag("Player2").Length <= 0) {
            StartCoroutine(UpdateScore(p1Score, p1Text, "Player"));
        } else if(GameObject.FindGameObjectsWithTag("Player2").Length > 0 || GameObject.FindGameObjectsWithTag("Player2").Length > 0) {
            StopAllCoroutines();
        }
    }

    IEnumerator UpdateScore(int score, TMP_Text scoreText, string playerTag) {
        yield return new WaitForSeconds(timeToRespawn);
        if(playerTag == "Player"){
            p2Score++;
            score = p2Score;
        }
        else if(playerTag == "Player2") {
            p1Score++;
            score = p1Score;
        }
        print(score);
            scoreText.text = score.ToString();
        if(score <= 3) {
            if(score == 3) {
                _sceneCaller.CallScene("WinGame");
            }
            Destroy(GameObject.FindGameObjectWithTag(playerTag));
            _initializingScene.SpawnPlayers();
        } 
    }
}
