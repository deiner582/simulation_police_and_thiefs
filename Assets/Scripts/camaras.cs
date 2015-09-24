using UnityEngine;
using System.Collections;

public class camaras : MonoBehaviour {
	public Camera cam1,cam2,cam3,cam4,cam5,cam6,cam7,cam8,cam9;

	public UILabel l_cam;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("1")){
			cam1.enabled=true;

			cam2.enabled=false;
			cam3.enabled=false;
			cam4.enabled=false;
			cam5.enabled=false;
			cam6.enabled=false;
			cam7.enabled=false;
			cam8.enabled=false;
			cam9.enabled=false;
			l_cam.text="1";
	}
		if (Input.GetKeyDown ("2")){
			cam1.enabled=false;
			
			cam2.enabled=true;
			cam3.enabled=false;
			cam4.enabled=false;
			cam5.enabled=false;
			cam6.enabled=false;
			cam7.enabled=false;
			cam8.enabled=false;
			cam9.enabled=false;
			
			l_cam.text="2";
	
		}
	if (Input.GetKeyDown ("3")){
			cam1.enabled=false;
			
			cam2.enabled=false;
			cam3.enabled=true;
			cam4.enabled=false;
			cam5.enabled=false;
			cam6.enabled=false;
			cam7.enabled=false;
			cam8.enabled=false;
			cam9.enabled=false;
			
			l_cam.text="3";
		}
		if (Input.GetKeyDown ("4")){
			cam1.enabled=false;
			
			cam2.enabled=false;
			cam3.enabled=false;
			cam4.enabled=true;
			cam5.enabled=false;
			cam6.enabled=false;
			cam7.enabled=false;
			cam8.enabled=false;
			cam9.enabled=false;
			l_cam.text="4";
		}
		if (Input.GetKeyDown ("5")){
			cam1.enabled=false;
			
			cam2.enabled=false;
			cam3.enabled=false;
			cam4.enabled=false;
			cam5.enabled=true;
			cam6.enabled=false;
			cam7.enabled=false;
			cam8.enabled=false;
			cam9.enabled=false;
			
			l_cam.text="5";
		}
		if (Input.GetKeyDown ("6")){
			cam1.enabled=false;
			
			cam2.enabled=false;
			cam3.enabled=false;
			cam4.enabled=false;
			cam5.enabled=false;
			cam6.enabled=true;
			cam7.enabled=false;
			cam8.enabled=false;
			cam9.enabled=false;
			l_cam.text="6";
		}
		if (Input.GetKeyDown ("7")){
			cam1.enabled=false;
			
			cam2.enabled=false;
			cam3.enabled=false;
			cam4.enabled=false;
			cam5.enabled=false;
			cam6.enabled=false;
			cam7.enabled=true;
			cam8.enabled=false;
			cam9.enabled=false;
			l_cam.text="7";
		}
		if (Input.GetKeyDown ("8")){
			cam1.enabled=false;
			
			cam2.enabled=false;
			cam3.enabled=false;
			cam4.enabled=false;
			cam5.enabled=false;
			cam6.enabled=false;
			cam7.enabled=false;
			cam8.enabled=true;
			cam9.enabled=false;
			l_cam.text="8";
		}
		if (Input.GetKeyDown ("9")){
			cam1.enabled=false;
			
			cam2.enabled=false;
			cam3.enabled=false;
			cam4.enabled=false;
			cam5.enabled=false;
			cam6.enabled=false;
			cam7.enabled=false;
			cam8.enabled=false;
			cam9.enabled=true;
			l_cam.text="9";
		}
			
	}
}

