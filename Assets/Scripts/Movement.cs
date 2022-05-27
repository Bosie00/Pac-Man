using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 8f;
    public Vector2 initialDirection;
    public LayerMask wallsLayer;

    public new Rigidbody2D rigidbody;
    public Vector2 direction;
    public Vector2 nextDirection;
    public Vector3 startingPosition;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        startingPosition = transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        direction = initialDirection;
        nextDirection = Vector2.zero;
        transform.position = startingPosition;
    }

    // Update is called once per frame
    private void Update()
    {
        if (nextDirection != Vector2.zero) {
            SetDirection(nextDirection);
        }
    }

    private void FixedUpdate()
    {
        Vector2 position = rigidbody.position;
        Vector2 translation = direction * speed * Time.fixedDeltaTime;

        rigidbody.MovePosition(position + translation);
    }

    public void SetDirection(Vector2 direction, bool forced = false)
    {
        if (forced || !Occupied(direction))
        {
            this.direction = direction;
            nextDirection = Vector2.zero;
        }
        else
        {
            nextDirection = direction;
        }
    }

    public bool Occupied(Vector2 direction)
    {
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, Vector2.one * 0.75f, 0f, direction, 1.5f, wallsLayer);
        Debug.Log(1);
        return hit.collider != null;
    }
}
