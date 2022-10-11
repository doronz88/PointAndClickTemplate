using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : MonoBehaviour
{
    public string _correctCode;
    public string _enteredCode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AppendString(string str)
    {
        _enteredCode += str;
        Debug.Log("enteredCode: " + _enteredCode);

        if (_correctCode == _enteredCode)
        {
            Debug.Log("correct!!!");
        }        
    }
}
