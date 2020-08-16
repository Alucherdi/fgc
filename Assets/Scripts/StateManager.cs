using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour {
    private int state = 0;

    private void Start() {
    }

    private void Update() {
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.tag == "Ground") {
            GetComponent<PlayerMovement>().Kill();
        }
    }
}
