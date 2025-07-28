using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Sprite[] Sprites; // Index 0 = left, 1 = up, 2 = right, 3 = down
    public float moveSpeed = 2f;
    private Vector2 movement;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (movement.x > 0)
        {
            spriteRenderer.sprite = Sprites[2];
        } else if (movement.x < 0)
        {
            spriteRenderer.sprite = Sprites[0];
        }
        if (movement.y > 0)
        {
            spriteRenderer.sprite = Sprites[1];
        } else if (movement.y < 0)
        {
            spriteRenderer.sprite = Sprites[3];
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + (movement.normalized * moveSpeed * Time.deltaTime));
    }
}
