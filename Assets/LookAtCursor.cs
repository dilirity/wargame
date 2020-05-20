using UnityEngine;

public class LookAtCursor : MonoBehaviour
{
    Ray cameraRay;
    RaycastHit cameraRayHit;
    Vector3 targetPosition;

    // Update is called once per frame
    void Update()
    {
        cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(cameraRay, out cameraRayHit))
        {
            // ...make the cube rotate (only on the Y axis) to face the ray hit's position 
            targetPosition = new Vector3(cameraRayHit.point.x, transform.position.y, cameraRayHit.point.z);
            transform.LookAt(targetPosition);
        }
 
        transform.LookAt(targetPosition);
    }
}
