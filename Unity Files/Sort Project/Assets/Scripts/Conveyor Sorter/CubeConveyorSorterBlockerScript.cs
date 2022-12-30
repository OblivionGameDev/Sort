using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeConveyorSorterBlockerScript : MonoBehaviour
{
    public GameObject nonCubeBlocker;
    public Material conveyorBeltMaterial;
    public float conveyorBeltSpeed = 1f;
    private bool stopConveyorBelt;
    float currentVelocity = 0f;
    float offset;
    public Vector2 mAnimationRate = new Vector2(1.0f, 0.0f);
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Cube")
        {
            nonCubeBlocker.SetActive(false);
        } 
        else nonCubeBlocker.SetActive(true);

        if(other.tag == "Sphere")
        {
            stopConveyorBelt = true;   
        } 
    }
    void Update()
    {
        if(stopConveyorBelt)
        { 
            float offset = Time.deltaTime * conveyorBeltSpeed;
            Debug.Log(offset);
            conveyorBeltMaterial.SetTextureOffset("Texture2D_f719ec258e584240bc510085815317ce", new Vector2(offset, offset));
        }
    }

}
