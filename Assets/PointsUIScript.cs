using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsUIScript : MonoBehaviour
{
    public GameObject textGameObject;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textGameObject.GetComponent<TextMesh>().text = "Points: " + PlayerScript.PlayerPoints;
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
