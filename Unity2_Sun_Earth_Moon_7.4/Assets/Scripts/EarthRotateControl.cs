using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotateControl : MonoBehaviour
{
    public GameObject revolutionCenter = default;
    public float earthRotateSpeed = 50f;
    public float earthRevolutionSpeed = 30f;
    private Vector3 earthRotation = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateEarth();
        RevolutionEarth();
    }

    private void RotateEarth()
    {
        earthRotation.y = (earthRotateSpeed * Time.deltaTime);
        transform.Rotate(earthRotation);
    }

    private void RevolutionEarth() 
    {
        transform.RotateAround(revolutionCenter.transform.position, Vector3.up, earthRevolutionSpeed * Time.deltaTime);
    }
}
