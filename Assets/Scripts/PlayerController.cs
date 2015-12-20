using UnityEngine;
using System.Collections;
using UnityEngine.UI; //namespace that holds details of UI toolset


public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;//variable holds reference rb
    private int count;
    public Text countText; //refers to text that keeps score of player
    public Text winText;

    // Use this for initialization & called on the firsst frame the script is active
    void Start()
    {
        //find and attaxh a rigidbody function if it exists
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";

}

    // Update is called once per frame (before rendering a frame)
    /* void Update()
     {
         //most game code will go here
     }*/

    //called before any physical calculations are done
    void FixedUpdate()

    {
        //physics code will go here (ie. apply forces to rigid body)

        float moveHorizontal = Input.GetAxis("Horizontal"); //left or right (x)
        float moveVertical = Input.GetAxis("Vertical"); //forward or backward (z)
        // (after =) grabs input from player through keyboard
        // (before =) record input from hor and ver axis controlled by keys on keyboard
        //player game object uses rigid body & interacts with physics

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);



    }
    //this functino will be called by Unity 
    //when it player game object a trigger collider
    //reference to trigger collider we have touched 
    //(gives us a way to get a hold of the collider we touch, ie rotating cube)
    void OnTriggerEnter(Collider other)
    {
        //(want to collect object without colliding)
        //Destroy(other.gameObject);

        //when touch another trigger collider...
        //...destroy game object that trigger collider is attached to
        //...when destroy...then gameobject, all components, all children & their components removed 

        //instead destroy, want deactivate it


        //tag = allow identiy game object by comparing to string

        if (other.gameObject.CompareTag("Pick Up"))//compare's trigger collider's tag with anoher string
        {
            other.gameObject.SetActive(false);//like clicking active checkbox next to name field in inspector
            count++;
            SetCountText();
        }
        //above code called every time we call trigger collider


    }

    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();
        if(count >=12)
        {
            winText.text = "You Win!";
        }
    }
}