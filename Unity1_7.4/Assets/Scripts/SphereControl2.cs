using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl2 : MonoBehaviour
{
    public GameObject targetCube = default;

    private float sphere2Speed = 30.0f;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(targetCube.transform.position,
            Vector3.right, sphere2Speed * Time.deltaTime);
    }
}
