using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotateControl : MonoBehaviour
{
    public GameObject revolutionCenter2 = default;
    public float moonRotateSpeed = 50f;
    public float moonRevolutionSpeed = 50f;
    private Vector3 moonRotation = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateMoon();
        RevolutionMoon();
    }

    public void RotateMoon()
    {
        moonRotation.y = (moonRotateSpeed * Time.deltaTime);
        transform.Rotate(moonRotation);
    }

    public void RevolutionMoon()
    {
        transform.RotateAround(revolutionCenter2.transform.position, Vector3.up, moonRevolutionSpeed * Time.deltaTime);
    }

}
