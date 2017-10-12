using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public static int PlayerPoints;
    // Use this for initialization
    void Start()
    {
        PlayerPoints = PlayerPrefs.GetInt("PlayerPoints");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void AddPoints(int points)
    {
        PlayerPoints++;
        PlayerPrefs.SetInt("PlayerPoints", PlayerPoints);
        GameObject.Find("PointsText").GetComponent<PointsUIScript>().EditText();
    }
}
