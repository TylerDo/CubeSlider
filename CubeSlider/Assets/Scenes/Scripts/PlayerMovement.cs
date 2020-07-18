using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 200f;
    public float sidewaysForce = 200f;
  
    // Update is called once per frame
    void FixedUpdate()
    {
        //Add a forward force to z axis
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);//Amount of seconds the computer draws a frame/ higher rate lower value

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
