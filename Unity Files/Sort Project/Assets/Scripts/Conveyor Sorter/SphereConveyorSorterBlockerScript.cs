using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereConveyorSorterBlockerScript : MonoBehaviour
{
    public GameObject nonSphereBlocker;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Sphere")
        {
            nonSphereBlocker.SetActive(false);
        } 
        else nonSphereBlocker.SetActive(true);
    }

}
