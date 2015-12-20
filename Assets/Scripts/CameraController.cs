using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player; //reference to player (aka sphere)
    private Vector3 offset; //subtract transform position of camera from that of player
                            // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // used for follow cameras, procedural animation, and gathering last states 
    //runs every frame just like Update (guarenteed to run after all items processed in Update)
    //...ie we know absolutely player has moved for that frame (when position of camera is set)
    void LateUpdate()
    {

        transform.position = player.transform.position + offset;
        //as move players with controls on keyboard...
        //...each fram before camera displays what we can see...
        //...camera is moved to a different position and is aligned with player object 
        //...(as if it were a child of that object without rolling around game board)
    }
}
