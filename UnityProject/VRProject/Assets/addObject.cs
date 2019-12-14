using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addObject : MonoBehaviour
{

    public static int count = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 10; i++) {
            GameObject obj = (GameObject)Resources.Load ("Player");
            GameObject instance = Instantiate (obj, new Vector3(Random.value * 10, Random.value * 10 + 15, Random.value * 10), Quaternion.identity);
            float rColor = Random.value;
            float gColor = Random.value;
            float bColor = Random.value;
            Debug.Log(rColor + ":" + gColor + ":" + bColor);
            instance.GetComponent<Renderer>().material.color = new Color(rColor, gColor, bColor, 1.0f);
            instance.GetComponent<Transform>().localScale = new Vector3(Random.value * 0.5f, Random.value * 0.5f, Random.value * 0.5f);
        }
    }
}
