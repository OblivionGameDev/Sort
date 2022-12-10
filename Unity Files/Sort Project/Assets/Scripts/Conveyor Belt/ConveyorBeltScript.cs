using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBeltScript : MonoBehaviour
{
    public Transform endPoint;
    public int speed;

    void OnTriggerStay(Collider other)
    {
        other.attachedRigidbody.MovePosition(other.transform.position + endPoint.position * speed * Time.deltaTime);
    }
}
