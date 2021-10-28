using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour {
    [SerializeField] float time = 5f;
    [SerializeField] TMP_Text timerText;

    private SceneCaller _sceneCaller;

    void Start() {
        _sceneCaller = FindObjectOfType<SceneCaller>();
        timerText.text = time.ToString();
    }

    // Update is called once per frame
    void Update() {
        if(time > 0) {
            time -= Time.deltaTime;
            int roundedTime = (int)time;
            timerText.text = roundedTime.ToString();

            if(time <= 0) {
                print("times up");
                _sceneCaller.CallScene("GameOver");
            }
        } 
    }
}
