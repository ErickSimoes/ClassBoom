using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorerBehaviour : MonoBehaviour {
    public static StorerBehaviour instance;
    public int player1SkinIndex, player2SkinIndex;
    void Awake() {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void DestroyStorer() {
        Destroy(this.gameObject);
    }
}
