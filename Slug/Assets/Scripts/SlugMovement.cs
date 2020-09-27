using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlugMovement : MonoBehaviour
{
    public float power = 10f;
    public Rigidbody rb;


    public Vector3 minPower;
    public Vector3 maxPower;

    TrajectoryLine tl;

    public Camera cam;

    Vector3 force;
    Vector3 startPoint;
    Vector3 endPoint;

    private void Start()
    {
        tl = GetComponent<TrajectoryLine>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            startPoint = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5)); //cam.nearClipPlane));
            
            Debug.Log(startPoint);
            rb.isKinematic = true;

        }

        if (Input.GetMouseButton(0))
        {
            Vector3 currentPoint = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5)); //cam.nearClipPlane));

            tl.RenderLine(startPoint, currentPoint);

        }

        if (Input.GetMouseButtonUp(0))
        {
            endPoint = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5)); //cam.nearClipPlane));
            
            rb.isKinematic = false;

            force = new Vector3(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y), 0);
            rb.AddForce(force * power, ForceMode.Impulse);

            tl.EndLine();
        }
    }
}
