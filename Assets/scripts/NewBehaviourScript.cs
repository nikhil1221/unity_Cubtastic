
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideWay = 500f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //forwardForce in this is the speed of the of the block
        rb.AddForce(0, 0, forwardForce*(Time.deltaTime)); //ADD FORCE TO THE BOX

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWay * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWay * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(rb.position.y<-1f)
        {
            FindObjectOfType<GameManger>().EndGame();
        }
    }
}
