using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public Rigidbody thisrigidbody;
    public float jumpMultiplier;
    public float MovementMultiplier;

    public float HorizontalMultiplier;
    public float VerticalMultiplier;

    public float WalkHorizontal;
    public float WalkVertical;

    public float GravityUp;
    public float GravityDown;

    public float JumpForce;
    public float Jumptime;
    public float JumpTimeCounter;
    public float JumpForceMultiplier;

   



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
            if (JumpTimeCounter > 0)
            {
                Jump();
            }
        }

        if (thisrigidbody.velocity.y < 0)
        {
            thisrigidbody.velocity = thisrigidbody.velocity + (Vector3.down * Physics.gravity.y * GravityDown * Time.fixedDeltaTime);

        }

        if (thisrigidbody.velocity.y > 0)
        {

            thisrigidbody.velocity = thisrigidbody.velocity + (Vector3.up * Physics.gravity.y * GravityUp * Time.fixedDeltaTime);
        }






        if (Input.GetKey(KeyCode.A)) {

            thisrigidbody.transform.Translate(WalkHorizontal,0,0);

        }
        else {

            thisrigidbody.transform.Translate(0, 0, 0);

        }

        if (Input.GetKey(KeyCode.D))
        {

            thisrigidbody.transform.Translate(-WalkHorizontal, 0, 0);


        }
        else
        {

            thisrigidbody.transform.Translate(0, 0, 0);

        }

        if (Input.GetKey(KeyCode.W))
        {



        }
        else
        {


        }
        if (Input.GetKey(KeyCode.S))
        {

           

        }
        else
        {

           
        }

    }


    private void OnCollisionEnter(Collision collision)
    {


        if(Input.GetKeyDown(KeyCode.E) || collision.gameObject.tag == "Pill") {

            thisrigidbody.velocity = new Vector2(0, JumpForce * JumpForceMultiplier);
            JumpTimeCounter -= Time.deltaTime;
            Debug.Log("Clicked");
        }
    }








    void Jump() {



        thisrigidbody.velocity = Vector3.up *MovementMultiplier;


    }
}
