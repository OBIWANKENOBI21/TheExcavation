using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("asta lavesta baby");
        Debug.Log("i'll be back");
        Debug.Log("i'm back baby");

        transform.Translate(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("wasssuuup");
        transform.Translate(0.1f, 0.1f, 0.1f);
    }
}
