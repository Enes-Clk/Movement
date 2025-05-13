// Karakterin klavye ile hareket etmesini sağlar (2D oyunlar için)
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        rb.linearVelocity = new Vector3(moveX * speed,0f,moveY * speed);
    }
}