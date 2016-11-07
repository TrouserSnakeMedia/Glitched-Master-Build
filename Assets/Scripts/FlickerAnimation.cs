using UnityEngine;
using System.Collections;

public class FlickerAnimation : MonoBehaviour {
    public Animator anim; //creates a empty animator called anim thats public  so it can be set in the unity inspector 
    bool idle; // creates a  bool called idle
    bool attack; // creates a  bool called attack
    bool latch; // creates a  bool called latch
    GameObject theFlicker; // creates a empty gameobject called theFlicker
   // public Transform target;
    void Awake()
    {          
        anim = gameObject.GetComponent<Animator>(); // finds and sets the animator named anim to equal animator that is attached to this gameobject this script is attached to

    }
    // Use this for initialization
    void Start () {
        theFlicker = GameObject.FindGameObjectWithTag("EnemySprite"); // makes the gameobject theFlicker = the gameobject with tag EnemySprite which should be the Enemy gameobject  in the hierarchy
    }
	
	// Update is called once per frame
	void Update () {
        attack= theFlicker.GetComponent<enemyscript>().seePlayer;  // sets the bool attack to equal the bool seePlayer thats in enemy script which is attached to theFlicker gameobject
        idle = theFlicker.GetComponent<enemyscript>().seePlayer; // sets the bool idle to equal the bool seePlayer thats in enemy script which is attached to theFlicker gameobject
        latch = theFlicker.GetComponent<enemyscript>().latched; // sets the bool latch to equal the bool theFlicker thats in enemy script which is attached to theFlicker gameobject

        if (attack == true) // checks to see if attack is true and attack equals seePlayer so if push is true than attack is true
        { 
           // transform.LookAt(target);
            anim.SetInteger("FlickerSwitch", 2); // plays the charge animation
           // transform.Rotate(90, 0, 0);
        }
        else if (attack== false && latch == false) //  checks if the Flicker isn't charging and it isn't latched to player
        {
           
            anim.SetInteger("FlickerSwitch", 4); // plays the idle animation
          //  transform.Rotate(90, 0, 0);
        }
         if (latch == true)  //  checks if the Flicker is latched to player
        { 
          //  transform.LookAt(target);

            anim.SetInteger("FlickerSwitch", 3); // plays the Flicker latched animation
            //transform.Rotate(90, 0, 0);
        }
      

    }
}
