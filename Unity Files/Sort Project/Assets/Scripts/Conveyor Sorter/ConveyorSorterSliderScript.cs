using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConveyorSorterSliderScript : MonoBehaviour
{
    [SerializeField] private Slider slider;
    
    public float speed;
    public float movementSpeed;
    public GameObject right;
    public GameObject left;
    public GameObject conveyorSorters;
    private Rigidbody conveyorSortersRB;
    private float value;

    public void Start()
    {
        conveyorSortersRB = conveyorSorters.GetComponent<Rigidbody>();
    }

    public void sliderChangeMovement(float newValue)
    {
      
    }


    void FixedUpdate()
    {
        /* Not the best way of doing movement
        if(conveyorSorters.transform.position.x < 0.25 && value>0)
        {
        conveyorSorters.transform.position = Vector3.MoveTowards(conveyorSorters.transform.position, right.transform.position, speed);
        }
        else if (conveyorSorters.transform.position.x > -0.25  && value < 0)
        {
            conveyorSorters.transform.position = Vector3.MoveTowards(conveyorSorters.transform.position, left.transform.position, speed);
        }
        if (conveyorSorters.transform.position.x < -0.25f && value<0)
        {
            conveyorSortersRB.velocity = Vector3.zero;
        }
        if (conveyorSorters.transform.position.x > 0.25f && value>0)
        {
            conveyorSortersRB.velocity = Vector3.zero;
        }
        */
        value = slider.value;
        
        if(conveyorSorters.transform.position.x < 0.25 && value>0)
        {
        conveyorSortersRB.MovePosition(conveyorSorters.transform.position + right.transform.position * value * speed * (Time.deltaTime));
        }
        else if (conveyorSorters.transform.position.x > -0.25  && value < 0)
        {
            conveyorSortersRB.MovePosition(conveyorSorters.transform.position + left.transform.position * -value * speed * (Time.deltaTime));
        }
        if (conveyorSorters.transform.position.x < -0.25f && value<0)
        {
            conveyorSortersRB.velocity = Vector3.zero;
        }
        if (conveyorSorters.transform.position.x > 0.25f && value>0)
        {
            conveyorSortersRB.velocity = Vector3.zero;
        }
    }

    public void resetSlider()
    {
        slider.value = 0;
    }
    
}
