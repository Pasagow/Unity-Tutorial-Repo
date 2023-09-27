using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    string combinedString;
    [SerializeField]
    string editorString = "KAGURA BACHI RAGHHHHHH";
    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log("You have my sword");
        Debug.Log("And my bow");
        Debug.Log("And my axe!");
        */

        //declare variable FirstString
        string firstString = "You shall not";
        string secondString = " PASS!";
        
        combinedString = firstString + secondString;

        Debug.Log(combinedString);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Test,Test,Test");
        //transform.Translate(0.1f, 0, 0);
        Debug.Log(editorString);
    }
}
