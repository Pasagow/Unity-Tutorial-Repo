using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TestScript : MonoBehaviour
{
    string combinedString;

    Vector3 changingScale = new Vector3(1.0f, 1.0f, 1.0f);

    [SerializeField]
    string editorString = "KAGURA BACHI RAGHHHHHH";

    [SerializeField]
    float targetScale = 1.0f;

    [SerializeField]
    SpriteRenderer playerSprite = null;

    [SerializeField]
    Color SpriteColor = Color.white;
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

        playerSprite.color = SpriteColor;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Test,Test,Test");
        //transform.Translate(0.1f, 0, 0);
        //Debug.Log(editorString);
        targetScale = targetScale + 0.1f;
        Debug.Log(targetScale);

        changingScale.x = targetScale;
        changingScale.y = targetScale;
        changingScale.z = targetScale;

        transform.localScale = changingScale;

    }
}
