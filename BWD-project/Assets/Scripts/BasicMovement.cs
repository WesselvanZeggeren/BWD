using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    public float speed = 0;

    // Update is called once per frame
    void Update()
    {
         
        this.updateMovement();
    }

    private void updateMovement()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(x, 0.0f, z);

        transform.position += (direction * this.speed);
    }
}
