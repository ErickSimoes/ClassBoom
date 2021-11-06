using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;

public class PauseController : MonoBehaviour {
    [SerializeField] SceneCaller _sceneCaller;
    public bool isPaused = false;
    [SerializeField] GameObject pauseCanvas;
    private void Update() {
        if(Input.GetKeyDown(KeyCode.P))
            TogglePause();
    }
    public void TogglePause() {
        if (isPaused) {
            pauseCanvas.SetActive(false);
            Time.timeScale = 1f;
            isPaused = false;
        } else {
            pauseCanvas.SetActive(true);
            Time.timeScale = 0f;
            isPaused = true;
        }
    }
}
