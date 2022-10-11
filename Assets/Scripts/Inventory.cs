using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Hashtable hashtable;

    private void Awake()
    {
        hashtable = new Hashtable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void appendItem(GameObject gameObject)
    {
        hashtable.Add(gameObject.name, gameObject);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

    private void OnMouseUp()
    {
        Debug.Log("Inventory:");
    }
}
