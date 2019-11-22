using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quest : MonoBehaviour
{
    public string New;
    public GameObject text;
    public string New1;
    public GameObject text1;
    public float timer;
    private int delay;
    private int a;
    private int b;
    private int c;
    public int v;
    // Start is called before the first frame update
    void Start()
    {
        delay = 400;
        a = 800;
        b = 1200;
        c = 1600;
        v = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer > delay)
        {
            New = "После того как вы попадете в первые 4 мишени,";
            New1 = "появятся 2 новые, которые будут двигаться";
            text.GetComponent<TextMesh>().text = New;
            text1.GetComponent<TextMesh>().text = New1;
            delay = 12000;
        }
        if (timer > a)
        {
            New = "Первые четыре дают по одному очку,";
            New1 = "а остальные по 2 очка";
            text.GetComponent<TextMesh>().text = New;
            text1.GetComponent<TextMesh>().text = New1;
            a = 120000;
        }
        if (timer >b)
        {
            New = "У вас всего 6 попыток";
            Destroy(text1);
            text.GetComponent<TextMesh>().text = New;
            b = 1200000;
        }
        if (timer > c)
        {
            Destroy(text);
            v = 1;
        }
    }
}
