using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    [SerializeField]
    private Transform _RightHandAnchor;

    private static bool shotted = false;

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)) {
            shotted = true;
            var pointer = _RightHandAnchor;
            GameObject obj = (GameObject)Resources.Load ("Cylinder");
            GameObject instance = Instantiate (obj, pointer.position, new Quaternion(pointer.rotation.x, pointer.rotation.y, pointer.rotation.z, 1));
        }
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger)) {
            shotted = false;
        }
    }
}
