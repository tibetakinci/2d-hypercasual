using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject obj;
    private float Timer = 1;
    // Start is called before the first frame update
    void Start()
    {
        obj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            float number = UnityEngine.Random.Range(8.4f, -8.4f);
            GameObject newObj = Instantiate(obj, new Vector3(number, 2.5f, 0), Quaternion.identity);
            newObj.SetActive(true);
            Destroy(newObj, 1.08f);
            Timer = 1f;
        }
    }
}