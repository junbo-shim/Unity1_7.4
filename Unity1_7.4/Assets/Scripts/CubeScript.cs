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
        Debug.Log("�̰� ����Ƽ�� Hello World�̴�");

        //transform.Rotate(new Vector3(0f, 45f, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("�̰͵� ��𼱰� Call �ϰ� �ִ�");

        cubeRotation.y += (rotationSpeed * Time.deltaTime);
        transform.Rotate(cubeRotation);
    }
}
