using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;


public class BowlingBall : MonoBehaviour 
{
    
    public float powerPerPixel=12.5f; //  force per one pixel flick 50f
    public float maxPower=22.5f; // force limiter 90f
    public float sensitivity=0.05f; // the higher, the more control to the right and left 0.175
    
    private Vector3 touchPos;
    private bool isRolling; //  true after throwing the ball
    

    void Start () 
    {
        isRolling = false;
    }
    
    void Update () 
    {
        if (!isRolling) 
        {
            if (Input.GetMouseButtonDown(0))
            {
                touchPos = Input.mousePosition; // remember the initial touch position
            }  
            
            else if (Input.GetMouseButtonUp(0))
            {
                isRolling = true; //stop detecting touches
                Vector3 releasePos = Input.mousePosition;
                float swipeDistanceY = releasePos.y - touchPos.y; // flicking distance in Y-axis
                float power = swipeDistanceY * powerPerPixel;
                float swipeDistanceX = releasePos.x - touchPos.x; // flicking distance in X-axis
                float throwDirection = swipeDistanceX * sensitivity;
                
                if (power < 0) 
                {
                    power *= -1; // invert the sign if the value is negative
                }
            
                if (power > maxPower) 
                {
                    power = maxPower; // apply force limiter
                }
                
                GetComponent<Rigidbody>().AddForce(new Vector3(throwDirection, 0, power), ForceMode.Impulse); // apply force to the ball
            }

        }


    }

   
}


















/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    public float force;
    // Use this for initialization
    private List<Vector3> pinPositions;
    private List<Quaternion> pinRotations;
    private Vector3 ballPosition;
    private int counterPin=0;

    void Start()
    {
        var pins = GameObject.FindGameObjectsWithTag("Pin");
        pinPositions = new List<Vector3>();
        pinRotations = new List<Quaternion>();
        foreach (var pin in pins)
        {
            pinPositions.Add(pin.transform.position);
            pinRotations.Add(pin.transform.rotation);
        }
        
        ballPosition = GameObject.FindGameObjectWithTag("Ball").transform.position;
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, force));
            Debug.Log("Hola");
        }
           
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 0), ForceMode.Impulse);
        }
         
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, 0), ForceMode.Impulse);
        }
            
        if (Input.GetKeyUp(KeyCode.R))
        {
            var pins = GameObject.FindGameObjectsWithTag("Pin");
            
            for (int i = 0; i < pins.Length; i++)
            {
                //collision.gameObject.transform.parent.gameObject.tag
                var pinPhysics = pins[i].GetComponent<Rigidbody>();
                pinPhysics.velocity = Vector3.zero;
                pinPhysics.position = pinPositions[i];
                pinPhysics.rotation = pinRotations[i];
                pinPhysics.velocity = Vector3.zero;
                pinPhysics.angularVelocity = Vector3.zero;
                
                var ball = GameObject.FindGameObjectWithTag("Ball");
                ball.transform.position = ballPosition;
                ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
                ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            }
        }
        if (Input.GetKeyUp(KeyCode.B))
        {
            var ball = GameObject.FindGameObjectWithTag("Ball");
            ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            ball.transform.position = ballPosition;
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pin")
        {   
            counterPin+=1;
        }
        if (counterPin==1)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
*/  