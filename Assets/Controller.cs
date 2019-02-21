using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public Rigidbody thisrigidbody;
    public float jumpMultiplier;

    public float HorizontalMultiplier;
    public float VerticalMultiplier;



    // Start is called before the first frame update
    void Start()
    {
        thisrigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float Horizontal;
        Horizontal = Input.GetAxis("Mouse X");
        this.transform.Rotate(0, Horizontal * HorizontalMultiplier, 0);

        float Vertical;
        Vertical = Input.GetAxis("Mouse Y");
        this.transform.Rotate(-Vertical, 0, 0);
    }
}
