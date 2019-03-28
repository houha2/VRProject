using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beamDebug : MonoBehaviour {
    public float Range = 75f;
    private OVRCameraRig simCam;

	// Use this for initialization
	void Start () {
        simCam = GetComponentInParent<OVRCameraRig>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 origin = simCam.rightEyeCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
        Debug.DrawRay(origin, simCam.rightEyeCamera.transform.forward * Range, Color.green);
	}
}
