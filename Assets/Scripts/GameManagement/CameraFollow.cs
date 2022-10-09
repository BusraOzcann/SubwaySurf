using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    float speed = 0.125f;
    private void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, target.position.z + offset.z);
        transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x, transform.position.y, transform.position.z), speed);

        Vector3 temp = transform.position;
        temp.x = Mathf.Clamp(temp.x, -1, 1);
        transform.position = temp;
    }
}
