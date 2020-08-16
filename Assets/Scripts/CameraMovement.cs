using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public Transform player;
    public float speed;

    private void Start() {
    }

    private void FixedUpdate() {
        transform.position = new Vector3(
            player.position.x,
            transform.position.y,
            player.position.z - 10
        );
    }
}
