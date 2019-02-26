using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public Rigidbody thisrigidbody;
    public float jumpMultiplier;

    public float HorizontalMultiplier;
    public float VerticalMultiplier;

    public float WalkHorizontal;
    public float WalkVertical;

    public float GravityUp;
    public float GravityDown;

    public float JumpForce;
    public float Jumptime;
    public float JumpTimeCounter;

   



    // Start is called before the first frame update
    void Start()
    {
        thisrigidbody = GetComponent<Rigidbody>();
        Jumptime = JumpTimeCounter;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space)) {
            if (jumpMultiplier > 0)
            {
                thisrigidbody.velocity = new Vector2(thisrigidbody.velocity.x, JumpForce);
                JumpTimeCounter -= Time.deltaTime;
            }
        }




        float Horizontal;
        Horizontal = Input.GetAxis("Mouse X");
        this.transform.Rotate(0, Horizontal * HorizontalMultiplier, 0);

        float Vertical;
        Vertical = Input.GetAxis("Mouse Y");
        this.transform.Rotate(-Vertical, 0, 0);


        if (Input.GetKey(KeyCode.A)) {

            this.transform.Translate(WalkHorizontal,0, 0);

        }
        else {

            this.transform.Translate(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {

            this.transform.Translate(-WalkHorizontal,0 , 0);

        }
        else
        {

            this.transform.Translate(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {

            this.transform.Translate(0,0, -WalkVertical);

        }
        else
        {

            this.transform.Translate(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {

            this.transform.Translate(0, 0, WalkVertical);

        }
        else
        {

            this.transform.Translate(0, 0, 0);
        }

    }


    private void OnCollisionEnter(Collision collision)
    {


        if(Input.GetKeyDown(KeyCode.E) || collision.gameObject.tag == "Pill") {

            thisrigidbody.velocity = new Vector2(thisrigidbody.velocity.x, JumpForce * 20);
            JumpTimeCounter -= Time.deltaTime;
            Debug.Log("Clicked");
        }
    }
}
