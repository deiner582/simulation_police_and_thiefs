using UnityEngine;
using System.Collections;

public class ConoDeVision : MonoBehaviour {
//	private Vector3 fwd;
//	private Vector3 fwd2;
	public float angulo;
	//public float angulo1;
	public float distancia;
	//public int n_rayos;
	void Update() {
		Detectado();
	}

	public bool Detectado(){
		Quaternion startingAngle = Quaternion.AngleAxis(angulo, Vector3.up);
		Quaternion stepAngle = Quaternion.AngleAxis(0.4f, Vector3.up);
		RaycastHit hit;

		//Quaternion angle = transform.rotation * startingAngle;
		//Vector3 direction = angle * Vector3.forward*distancia;
		Vector3 direction = Vector3.forward*distancia;
		Vector3 pos = transform.position;

		for(int i = 0; i<=60; i++){
			//Debug.DrawRay(transform.position,direction,Color.yellow);

			if(Physics.Raycast(pos, direction, out hit,distancia))
			{
				if(hit.collider.name == "ladron")
					print ("ladron encontrado");
				//return hit.collider.transform.position;

					return true;
			}
			direction = stepAngle * direction;
			Debug.DrawRay(pos,direction,Color.yellow);
			//Debug.DrawRay(transform.position,direction*10,Color.yellow);
		}
		//return new Vector3(0,0,0);
		return false;
	} 

}
