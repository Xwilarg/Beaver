using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector2 from;
    private float turnSpeed = 5f;
    private Vector2 movement;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            switch (touch2.phase)
            {
                case TouchPhase.Began:
                    {
                        from = touch1.position - touch2.position;
                        break;
                    }
                case TouchPhase.Moved:
                    {
                        Vector2 current = touch1.position - touch2.position;
                        float targetAngle = Vector2.Angle(current, from);

                        if (targetAngle > 10)
                        {
                            this.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, targetAngle), turnSpeed);
                        }
                        else
                        {
                            GetComponent<Camera>().orthographicSize += (from - current).magnitude;
                        }
                        break;
                    }
            }
        }
    }

    
}
