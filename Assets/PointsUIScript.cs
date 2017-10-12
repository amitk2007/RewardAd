using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsUIScript : MonoBehaviour
{
    public GameObject textGameObject;
    // Use this for initialization
    void Start()
    {
        EditText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EditText()
    {
        textGameObject.gameObject.GetComponent<Text>().text = "Points: " + PlayerScript.PlayerPoints;
    }
    
    public void PlayGame()
    {
        Application.LoadLevel("Main");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
