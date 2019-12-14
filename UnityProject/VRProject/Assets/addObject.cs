using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddObject : MonoBehaviour
{

    public int count = 0;

    // Update is called once per frame
    void Update()
    {
        if (count % 100 == 0) {
            GameObject obj = (GameObject)Resources.Load ("Enemy");
            GameObject instance = Instantiate (obj, new Vector3(Random.value * 20 + 5, Random.value * 10 + 15, Random.value * 10), Quaternion.identity);
            float rColor = Random.value;
            float gColor = Random.value;
            float bColor = Random.value;
            instance.GetComponent<Renderer>().material.color = new Color(rColor, gColor, bColor, 1.0f);
            // instance.GetComponent<Transform>().localScale = new Vector3(Random.value * 0.5f + 1.0f, Random.value * 0.5f + 1.0f, Random.value * 0.5f + 1.0f);
        }
        count++;
    }
}
