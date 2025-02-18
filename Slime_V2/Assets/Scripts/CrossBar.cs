using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossBar : MonoBehaviour
{
    public Transform crossBar;
    public float speed;
    float movement;

    // Update is called once per frame
    void Update()
    {
        movement = Time.deltaTime * speed;
        crossBar.transform.position = transform.position + new Vector3(0f, movement, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hi");
        if (collision.CompareTag("topDeathZone"))
        {
            Destroy(gameObject);
        }
    }


}
