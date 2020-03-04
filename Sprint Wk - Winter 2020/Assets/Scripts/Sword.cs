using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public float smooth = 1f;
    private Quaternion targetRotation;

    private bool rotate;

    void Start()
    {
        targetRotation = transform.rotation;
        rotate = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (rotate)
            {
                targetRotation *= Quaternion.AngleAxis(90, Vector3.forward);
                rotate = false;
            }
            else
            {
                targetRotation *= Quaternion.AngleAxis(-90, Vector3.forward);
                rotate = true;
            }
        }
        

        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 10 * smooth * Time.deltaTime);
    }

}

