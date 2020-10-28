using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEdgeSnap : MonoBehaviour
{
	//Get the edges of the map
	public Transform leftBound;
	public Transform rightBound;
	public Transform topBound;
	public Transform bottomBound;

	Camera gameCamera;
	Transform playerTransform;

	private void Start()
	{
		//Create a reference to our camera.
		gameCamera = Camera.main;
		playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
	}

	// Update is called after all update functions are done.
	void LateUpdate()
	{
		transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z);
		//Save our position in a tmp variable that we can modify like we want
		Vector3 tmpPosition = transform.position;

		//Calculate the min and max position with boundry objects and camera size + aspect
		float minX = leftBound.position.x + gameCamera.orthographicSize * gameCamera.aspect;
		float maxX = rightBound.position.x - gameCamera.orthographicSize * gameCamera.aspect;
		//Clamp the position, so it can't go outside min or max interval
		tmpPosition.x = Mathf.Clamp(tmpPosition.x, minX, maxX);

		//Do the same for Y direction.
		float maxY = topBound.position.y - gameCamera.orthographicSize;
		float minY = bottomBound.position.y + gameCamera.orthographicSize;
		tmpPosition.y = Mathf.Clamp(tmpPosition.y, minY, maxY);

		//Set our position to the clamped position.
		transform.position = tmpPosition;
	}
}