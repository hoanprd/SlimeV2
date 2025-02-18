using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    float x;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        x = Input.GetAxisRaw("Horizontal");
        float moveStep = moveSpeed * x * Time.deltaTime;
        transform.position = transform.position + new Vector3(moveStep, -Time.deltaTime, 0);
    }
}
