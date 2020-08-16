using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private Rigidbody2D rb;
    private Vector2 movement;
    private bool isDead = false;

    public float speed = 5;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        if (isDead) return;
        float ix = Input.GetAxisRaw("Horizontal");
        float iy = Input.GetAxisRaw("Vertical");

        movement = new Vector2(ix, iy);
    }

    private void FixedUpdate() {
        if (isDead) return;
        rb.velocity = movement * speed;
    }

    public void Kill() {
        isDead = true;
        rb.velocity = Vector2.zero;
    }
}
