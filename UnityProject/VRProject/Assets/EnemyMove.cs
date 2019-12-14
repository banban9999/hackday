using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Update is called once per frame
    private int count = 0;

    void Update()
    {
        if (count % 60 == 0) {
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.GetComponent<Rigidbody>().AddForce(new Vector3((Random.value - 0.5f) * 300, (Random.value - 0.5f) * 300, (Random.value - 0.5f) * 300));
        }
        count++;
    }
}
