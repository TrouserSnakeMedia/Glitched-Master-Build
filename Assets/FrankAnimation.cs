using UnityEngine;
using System.Collections;

public class FrankAnimation : MonoBehaviour {
	 GameObject flashLight;
	public Animator anim;


	// Use this for initialization
	void Awake ()
	{
		anim = gameObject.GetComponent<Animator> ();

	}
	void Start () {
		flashLight = GameObject.FindGameObjectWithTag("Flashlight");
	}





	// Update is called once per frame
	void Update ()
	{

	if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true ) 
		{
					print ("So animation?");
					anim.SetInteger ("WalktoWalkFlash", 3);
					
		}
			else if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false) 
		{
				print ("Is the animation?");
				anim.SetInteger ("WalktoWalkFlash", 2);
		}
		/*if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true && Input.GetKey(KeyCode.A)||GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true && Input.GetKey(KeyCode.W) || GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true && Input.GetKey(KeyCode.LeftArrow) ) 
		{
			print ("Really animation?");
			anim.SetInteger ("WalktoWalkFlash", 22);

		}
		else if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false && Input.GetKey(KeyCode.A)||GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false && Input.GetKey(KeyCode.W) || GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false && Input.GetKey(KeyCode.LeftArrow)) 
		{
			print ("Is this real animation?");
			anim.SetInteger ("WalktoWalkFlash", 39);

			
		}
		if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true && Input.GetKey(KeyCode.A)&& Input.GetKey(KeyCode.W) || GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true && Input.GetKey(KeyCode.LeftArrow)&& Input.GetKey(KeyCode.UpArrow)) 
		{
			
			anim.SetInteger ("WalktoWalkFlash", 29);
			print ("Really Diagonal animation?");
		}
		else if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false && Input.GetKey(KeyCode.A)&& Input.GetKey(KeyCode.W) || GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false && Input.GetKey(KeyCode.LeftArrow)&& Input.GetKey(KeyCode.UpArrow)) 
		{
			
			anim.SetInteger ("WalktoWalkFlash", 5);
			print ("Is the Diagonal animation?");
		}
		/*if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true && Input.GetKey(KeyCode.W)|| GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true && Input.GetKey(KeyCode.UpArrow) ) 
		{
			print ("Awesome animation?");
			anim.SetInteger ("WalktoWalkFlash", 22);

		}
		else if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false && Input.GetKey(KeyCode.W) || GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false && Input.GetKey(KeyCode.UpArrow)) 
		{
			print ("Cool animation?");
			anim.SetInteger ("WalktoWalkFlash", 39);


		}
		 if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true && Input.GetKey(KeyCode.W)&& Input.GetKey(KeyCode.D) || GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true && Input.GetKey(KeyCode.UpArrow)&& Input.GetKey(KeyCode.RightArrow)) 
		{
			print ("Awesome Diagonal animation?");
			anim.SetInteger ("WalktoWalkFlash", 29);

		}
		else if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false && Input.GetKey(KeyCode.W)&& Input.GetKey(KeyCode.D) || GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false && Input.GetKey(KeyCode.UpArrow)&& Input.GetKey(KeyCode.RightArrow)) 
		{
			print ("Cool Diagonal animation?");
			anim.SetInteger ("WalktoWalkFlash", 5);

		}
		if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true && Input.GetKey(KeyCode.D)|| GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true && Input.GetKey(KeyCode.RightArrow) ) 
		{
			print ("Really animation?");
			anim.SetInteger ("WalktoWalkFlash", 22);

		}
		else if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false && Input.GetKey(KeyCode.D) || GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false && Input.GetKey(KeyCode.RightArrow)) 
		{
			print ("Is this real animation?");
			anim.SetInteger ("WalktoWalkFlash", 39);


		}
		if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true && Input.GetKey(KeyCode.D)&& Input.GetKey(KeyCode.S) || GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true && Input.GetKey(KeyCode.RightArrow)&& Input.GetKey(KeyCode.DownArrow)) 
		{
			print ("Really Diagonal animation?");
			anim.SetInteger ("WalktoWalkFlash", 29);

		}
		else if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false && Input.GetKey(KeyCode.D)&& Input.GetKey(KeyCode.S) || GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false && Input.GetKey(KeyCode.RightArrow)&& Input.GetKey(KeyCode.DownArrow)) 
		{
			print ("Is the Diagonal animation?");
			anim.SetInteger ("WalktoWalkFlash", 5);

		}
		if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true && Input.GetKey(KeyCode.S)|| GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true && Input.GetKey(KeyCode.DownArrow) ) 
		{
			print ("Really animation?");
			anim.SetInteger ("WalktoWalkFlash", 22);

		}
		else if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false && Input.GetKey(KeyCode.S) || GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false && Input.GetKey(KeyCode.DownArrow)) 
		{
			print ("Is this real animation?");
			anim.SetInteger ("WalktoWalkFlash", 39);


		}
		if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true && Input.GetKey(KeyCode.S)&& Input.GetKey(KeyCode.A) || GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == true && Input.GetKey(KeyCode.DownArrow)&& Input.GetKey(KeyCode.LeftArrow)) 
		{
			print ("Really Diagonal animation?");
			anim.SetInteger ("WalktoWalkFlash", 29);

		}
		else if (GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false && Input.GetKey(KeyCode.S)&& Input.GetKey(KeyCode.A) || GameObject.Find ("Spotlight").GetComponent<Light> ().enabled == false && Input.GetKey(KeyCode.DownArrow)&& Input.GetKey(KeyCode.LeftArrow)) 
		{
			print ("Is the Diagonal animation?");
			anim.SetInteger ("WalktoWalkFlash", 5);

		}

	*/}
}


