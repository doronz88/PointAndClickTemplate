using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1;
    public bool allowHorizontal = true;
    public bool allowVertical = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = allowHorizontal ? Input.GetAxis("Horizontal") : 0;
        float vertical = allowVertical ? Input.GetAxis("Vertical") : 0;

        if (horizontal == 0 && vertical == 0)
        {
            return;
        }

        Vector3 newPosition = new Vector3(transform.position.x + horizontal,
            transform.position.y + vertical, 0);

        transform.position = Vector3.MoveTowards(transform.position, newPosition, speed * Time.deltaTime);

    }

}
