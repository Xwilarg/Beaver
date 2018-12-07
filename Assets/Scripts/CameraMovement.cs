using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 firstPoint;
    private Vector3 secondPoint;
    private float xAngle = 0;
    private float yAngle = 0;
    private float xAngleTmp = 0;
    private float yAngleTmp = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                firstPoint = Input.GetTouch(0).position;
                xAngleTmp = xAngle;
                yAngleTmp = yAngle;
            }

            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                secondPoint = Input.GetTouch(0).position;
                xAngle = xAngleTmp + (secondPoint.x - firstPoint.x) * 180 / Screen.width;
                yAngle = yAngleTmp + (secondPoint.y - firstPoint.y) * 90 / Screen.height;

                this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0);
            }
        }
	}
}
