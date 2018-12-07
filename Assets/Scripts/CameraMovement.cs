using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float orthoZoomSpeed = 0.005f;
    private float oldAngle = 0;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            if (touchOne.phase == TouchPhase.Moved)
            {
                Zoom(touchZero, touchOne);
                Rotate(touchZero, touchOne);
            }
        }
    }

    private void Zoom(Touch touchZero, Touch touchOne)
    {
        Vector2 current = touchZero.position - touchOne.position;

        float newAngle = Mathf.Atan2(current.y, current.x);
        float deltaAngle = Mathf.DeltaAngle(newAngle, oldAngle) * Mathf.Rad2Deg;
        oldAngle = newAngle;

        this.transform.rotation *= Quaternion.Euler(0, 0, deltaAngle);
    }

    private void Rotate(Touch touchZero, Touch touchOne)
    {
        Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
        Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

        float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
        float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

        float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

        Camera camera = GetComponent<Camera>();
        camera.orthographicSize += deltaMagnitudeDiff * orthoZoomSpeed;
        camera.orthographicSize = Mathf.Max(camera.orthographicSize, 0.1f);
    }

}