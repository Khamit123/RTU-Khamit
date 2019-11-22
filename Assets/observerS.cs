using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class observerS : MonoBehaviour
{
    public int Targets = 6;
    public GameObject prefab;
    public GameObject prefab1;

    void Update()
    {

        if (Targets == 2)
        {
            prefab.SetActive(true);
            prefab1.SetActive(true);

        }
    if (Targets == 0)
        {
            Targets ++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
