using System;
using UnityEngine;

public class GameSettings : MonoBehaviour
{

    public GameObject cam;
    public Boolean useIsometricCamera;
    private FollowPlayer FollowPlayerScript;
    private Vector3 FollowPlayerOriginalOffset;
    private Camera childCam;

    // Start is called before the first frame update
    void Awake()
    {
        FollowPlayerScript = cam.GetComponent<FollowPlayer>();
        FollowPlayerOriginalOffset = FollowPlayerScript.offset;
        childCam = cam.transform.GetChild(0).gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (useIsometricCamera)
        {
            FollowPlayerScript.offset = new Vector3(0f, 0f, 0f);
            childCam.orthographic = true;
            childCam.nearClipPlane = -100f;
        }
        else
        {
            FollowPlayerScript.offset = FollowPlayerOriginalOffset;
            childCam.orthographic = false;
            childCam.nearClipPlane = 0.1f;
        }
    }
}
