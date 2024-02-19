using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public float value { get; private set; }

    // Components
    private Rigidbody shapeBody = null;

    // Start is called before the first frame update
    void Start()
    {
        shapeBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Move(Vector3 direction, float speed) {
        if (shapeBody == null) return;

        shapeBody.AddForce(direction * speed, ForceMode.Force);
    }

    private void Move(float speed) { 
        Move(Vector3.down, speed);
    }
}
