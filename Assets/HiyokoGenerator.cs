using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiyokoGenerator : MonoBehaviour
{

    //��������object���i�[
    public GameObject obj;
    //���������܂ł̃C���^�[�o��
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
