using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeButton : MonoBehaviour
{
    public string safeCode;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        FindObjectOfType<Safe>().AppendString(safeCode);
    }
}
