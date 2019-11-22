using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public GameObject prefab;
    public float speed;
    int timer;
    public int delay;
    float b,c;
    Vector3 st;
    Vector3 ed;
    private int N=0;
    public quest q;
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if(N < 6 & q.v==1)
        {
            timer++;
        } 
       
        if(timer>delay)
        {
            timer = 0;
            b = Random.Range(0.655f, 0.2f);
            c = Random.Range(0.5f, -0.5f);
            st = gameObject.transform.position;
            ed = new Vector3(1.3f, b, c);
            GameObject copy = Instantiate(prefab);
            copy.GetComponent<Rigidbody>().AddForce((ed - st) * speed);
            N++;
        }
    }
  
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(prefab);
    }
}
