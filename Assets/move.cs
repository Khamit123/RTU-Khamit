using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    //public GameObject obj;
    Vector3 st;
    Vector3 ed;
    bool dir = false;
    // Start is called before the first frame update
    void Start()
    {
        st = new Vector3(-1.512f, 0.624f, -0.708f);
        ed = new Vector3(-1.512f, 0.624f, -0.172f);
    }

    // Update is called once per frame
    void Update()
    {
        if(dir==false)
            {
            gameObject.transform.position=(gameObject.transform.position + new Vector3(0,0,speed));
           }
        if (dir==true)
            {
            gameObject.transform.position = (gameObject.transform.position - new Vector3(0, 0, speed));
        }
        if(gameObject.transform.position.z > ed.z)
        {
            dir = true;
        }
        if (gameObject.transform.position.z < st.z)
        {
            dir = false;
        }


    }
    
}
