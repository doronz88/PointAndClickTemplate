using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1;
    public bool enableHorizontal = true;
    public bool enableVertical = true;
    public float jumpFactor = 100;

    Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = enableHorizontal ? Input.GetAxis("Horizontal") : 0;
        float vertical = enableVertical ? Input.GetAxis("Vertical") * jumpFactor : 0;

        if (horizontal == 0 && vertical == 0)
        {
            return;
        }

        Vector3 newPosition = new Vector3(transform.position.x + horizontal,
            transform.position.y + vertical, 0);

        transform.position = Vector3.MoveTowards(transform.position, newPosition, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    }
}
