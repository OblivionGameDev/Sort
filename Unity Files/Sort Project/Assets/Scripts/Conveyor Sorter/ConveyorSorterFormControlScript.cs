using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConveyorSorterFormControlScript : MonoBehaviour
{
    public GameObject sphereConveyorSorter;
    public GameObject cubeConveyorSorter;

    public void chooseSphere()
    {
        sphereConveyorSorter.SetActive(true);
        cubeConveyorSorter.SetActive(false);
    }
    public void chooseCube()
    {
        sphereConveyorSorter.SetActive(false);
        cubeConveyorSorter.SetActive(true);
    } 
}


