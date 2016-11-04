using UnityEngine;
using System.Collections;

public class Pickupable : MonoBehaviour 
{
	GameObject mainCamera;
	bool carrying;
	GameObject carriedObject;
	public float maxDistance; // the distance a object can be away from the player as still be able to pick it up.
	public float smooth;
	private GameObject player;
	public Transform playerPosition;
	private Transform  pickupablePosition;
	float distance;

	// Use this for initialization
	void Start () {
		mainCamera = GameObject.FindWithTag("MainCamera");
		player = GameObject.FindWithTag ("Player");


	}

	// Update is called once per frame
	void Update () {
		if(carrying)
		{
			carry(carriedObject);
			checkDrop ();
		}
		else
		{
			pickup();
		}
	}

	void carry(GameObject o)
	{

	}

	void pickup()
	{
		if(Input.GetKey(KeyCode.Mouse0)) //Left mouse button is used to pick up the object
		{
			print ("key down");
			int x = Screen.width / 2;
			int y = Screen.height / 2;

			RaycastHit2D hit= Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero); // if cursor is over a object you make pick it up this is flows naturally with flashlight direction

			if (hit.collider != null  ) 
			{
				Pickitup p = hit.collider.GetComponent<Pickitup> (); // does not effect it from not working in fact this  makes it work
				print ("Picked up");
				if (p != null) 
				{
					carriedObject = p.gameObject;
					pickupablePosition= carriedObject.transform;
					distance = Vector3.Distance(playerPosition.position, pickupablePosition.position);// determines the distance between the player transform and the pickupable transform
					if(distance <= maxDistance)// determines if the actually distance between the player and pickupable is smaller or larger  or equal to the max distance and if smaller or equal the player may pick it up.
					{
						carrying = true;
						carriedObject.transform.SetParent(player.transform); // sets the object as a child of the player

					}

				}
			}
		}
	}
	void checkDrop()
	{
		if (Input.GetKeyUp (KeyCode.Mouse0))  // if the Left mouse button has been let go off the object is dropped
		{
			print ("Key up");

			dropObject ();
		}

	}
	void dropObject() 
	{
		carriedObject.transform.SetParent (null); // unsets the object as a child of the player
		carrying = false;
		carriedObject = null;
	}
}

