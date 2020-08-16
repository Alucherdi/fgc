using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private Rigidbody rb;
    private Vector3 movement;
    private bool isDead = false;

    public float speed = 5;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    private void Update() {
        if (isDead) return;
        float ix = Input.GetAxisRaw("Horizontal");
        float iy = Input.GetAxisRaw("Vertical");

        movement = new Vector3(ix, 0, iy);
    }

    private void FixedUpdate() {
        if (isDead) return;
        rb.velocity = movement * speed;
    }

    public void Kill() {
        isDead = true;
        rb.velocity = Vector3.zero;
    }
}
