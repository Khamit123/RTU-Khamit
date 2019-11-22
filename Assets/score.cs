using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public int scor;
    public string New;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        scor = 0;
        New = "Очки:0";
        text.GetComponent<TextMesh>().text = New;
    }

    // Update is called once per frame
    void Update()
    {
        if (scor >0)
        {
            New = "Очки:";
            text.GetComponent<TextMesh>().text = New+scor.ToString();
        }
    }
}
