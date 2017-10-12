using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesScript : MonoBehaviour
{
    
    public static int rand = -1;
    Transform empty;

    // Use this for initialization
    void Start()
    {
        empty = this.transform.parent;
        if (rand == -1||true)
        {
            rand = UnityEngine.Random.Range(1, empty.childCount);
            print(rand);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseUp()
    {
        print("rand = "+rand);
        GlobalAdvertisementsScript.GlobalAdsShow(empty.GetChild(rand) == this.transform);
        rand = UnityEngine.Random.Range(0, empty.childCount);
    }
}
