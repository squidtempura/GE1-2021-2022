using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject prefab;
    public int NumOfObjects = 6;
    public int loops = 10;
    public float radius = 1;
    void Start()
    {
        for(int i = 0; i < loops; i ++)
        {
            int NumOfObjects = 6*(i+1);
            float theta = (Mathf.PI*2.0f)/(float)NumOfObjects;
            for(int j = 0; j < NumOfObjects; j ++)
            {
                float angle = theta * j;
                Vector3 position = new Vector3(Mathf.Cos(angle)*1.2f*i,Mathf.Sin(angle)*1.2f*i);
                GameObject obj = GameObject.Instantiate(prefab, position, Quaternion.identity);
                obj.GetComponent<Renderer>().material.color = Color.HSVToRGB(i/10.0f,1,1);
                obj.transform.parent = transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
