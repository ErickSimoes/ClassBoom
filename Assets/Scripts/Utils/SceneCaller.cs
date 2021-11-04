using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCaller : MonoBehaviour {

    [SerializeField] string nameOfTheScene;
    private void Update() {
        if(Input.GetButtonDown("Lauch")) 
            CallScene(nameOfTheScene);
    }
    public void CallScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}
