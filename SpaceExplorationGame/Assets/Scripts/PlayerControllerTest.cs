using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{

	[Header("Player Variables")]
	public float SpeedX;
	
	[Header("Camera Variables")]
	public Camera Cam3D;
	public Camera Cam2D;

	void Start ()
	{
		Cam2D.enabled = true;
		Cam3D.enabled = false;
		Debug.Log("ARE YOU HAPPENING");
	}
	
	void Update ()
	{
		if (Cam2D.enabled == true)
		{
			transform.Translate(Input.GetAxisRaw("Horizontal") * SpeedX * Time.deltaTime, 0f, 0f);
		}
		else if (Cam3D.enabled == true)
		{
			transform.Translate(Input.GetAxisRaw("Vertical") * SpeedX * Time.deltaTime, 0f, Input.GetAxisRaw("Horizontal") * -SpeedX * Time.deltaTime);
		}

		if (Input.GetKeyDown(KeyCode.E) && Cam2D.enabled == true) 
		{
			Cam2D.enabled = false;
			Cam3D.enabled = true;
		} 
		else if (Input.GetKeyDown(KeyCode.E) && Cam3D.enabled == true)
		{
			Cam2D.enabled = true;
			Cam3D.enabled = false;
		}
	}
}
