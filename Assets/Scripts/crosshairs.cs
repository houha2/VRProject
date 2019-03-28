using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshairs : MonoBehaviour {
    public int damage = 1;
    public float shootRate = 0.1f; //how often person can shoot
    public float range = 75f;
    public float force = 100f;
    public Transform endOfShoot;
    private OVRCameraRig simCam;
    private WaitForSeconds duration = new WaitForSeconds(0.08f);
    private LineRenderer beamLine;
    private float nextShoot;

    public int score = 0;
	// Use this for initialization
	void Start () {
        beamLine = GetComponent<LineRenderer>();
        simCam = GetComponentInParent<OVRCameraRig>();
	}
	
	// Update is called once per frame
	void Update () {
       
        if (Input.GetKeyDown(KeyCode.L) && Time.time > nextShoot)
        {
            nextShoot = shootRate + Time.time;
            StartCoroutine(effect());
            Vector3 beamOrigin = simCam.rightEyeCamera.ViewportToWorldPoint(new Vector3(.5f, 0.5f, 0));
            RaycastHit hit;
            beamLine.SetPosition(0, endOfShoot.position);
            if (Physics.Raycast(beamOrigin, simCam.transform.forward, out hit, range)) {
                beamLine.SetPosition(1, hit.point);
                TargetSphere lives = hit.collider.GetComponent<TargetSphere>();
                if(lives != null)
                {
                    lives.Damage(damage);
                    score++;
                }
            }
            else
            {
                beamLine.SetPosition(1, simCam.transform.forward * range);
            }
        }
    }
    private IEnumerator effect()
    {
        beamLine.enabled = true;
        yield return duration;
        beamLine.enabled = false;
    }
}

