using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
            //time => makes it smooth and  frame rate independent
                    //...think of it how you're moving the player at different rate than at which the object is moving 
	}
}
