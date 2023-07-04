using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public float rotationSpeed = 50f;
    private Vector3 cubeRotation = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("이게 유니티의 Hello World이다");

        //transform.Rotate(new Vector3(0f, 45f, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("이것도 어디선가 Call 하고 있다");

        cubeRotation.y += (rotationSpeed * Time.deltaTime);
        transform.Rotate(cubeRotation);
    }
}
