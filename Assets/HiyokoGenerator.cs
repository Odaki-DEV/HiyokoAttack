using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiyokoGenerator : MonoBehaviour
{

    //生成するobjectを格納
    public GameObject obj;
    //生成されるまでのインターバル
    public float interval = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObj", 0.1f, interval);
    }

    void SpawnObj()
    {
        Instantiate(obj, transform.position, transform.rotation);
    }
}
