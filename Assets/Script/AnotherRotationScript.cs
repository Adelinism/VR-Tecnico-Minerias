using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherRotationScript : MonoBehaviour
{

    public Transform esteTransform;
    // Start is called before the first frame update
    void Start()
    {
        esteTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        moverRotation();
    }


    void moverRotation()
    {
        if (Input.GetKey(KeyCode.W))
        {
            esteTransform.Rotate(new Vector3(10f * Time.deltaTime, 0f, 0f));
            return;
        }

        if (Input.GetKey(KeyCode.S))
        {
            esteTransform.Rotate(new Vector3(-10f * Time.deltaTime, 0f, 0f));
            return;
        }
    }
}
