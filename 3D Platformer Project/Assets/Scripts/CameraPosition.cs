using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class CameraPosition : MonoBehaviour
{
    public Transform spotOne;
    public Transform spotTwo;
    public Transform spotThree;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = spotOne.position;
        transform.rotation = spotOne.rotation;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
    }

    public void MoveToSpotTwo()
    {
        transform.position = spotTwo.position;
        transform.rotation = spotTwo.rotation;
    }

    public void MoveToSpotThree()
    {
        transform.position = spotThree.position;
        transform.rotation = spotThree.rotation;
    }
}
