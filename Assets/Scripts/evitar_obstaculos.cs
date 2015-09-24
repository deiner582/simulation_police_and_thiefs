using UnityEngine;
using System.Collections;

public class evitar_obstaculos : MonoBehaviour {
	float distancia=2.0f;
	float tiempo;
	int tiempo1;
	int pos_ant;


	int pos_act;
	// Use this for initialization
    //void Start(){
	//	int posicion=Random.Range(0,5);
	//}
	
	// Update is called once per frame
	void Update () {
		//pos_act=Mathf.RoundToInt(this.transform.position.z);
		//print("actual : "+pos_act);
		Vector3 fwd=transform.TransformDirection(Vector3.forward);
		Debug.DrawRay(transform.position,fwd*5, Color.blue);
		Vector3 fwd2=transform.TransformDirection(Vector3.right);
		Debug.DrawRay(transform.position,fwd2*0.2f,Color.red);

		//tiempo+=Time.deltaTime;
		tiempo+=Time.deltaTime;
	//	print(tiempo);
		
		tiempo1=Mathf.RoundToInt(tiempo);
		//print(tiempo1);
		//if(tiempo1%5==0){


		//		pos_ant=Mathf.RoundToInt(this.transform.position.z);
		//		print("anterior : "+pos_ant);
				//print(	Mathf.RoundToInt(this.transform.position.z));
		//		if(pos_ant==pos_act){
		//			transform.Rotate (Vector3.up,180);
		//		}
				

	//	}


	
		if (Physics.Raycast (transform.position,fwd*5,5)){
		

			transform.Rotate (Vector3.up,90*Time.deltaTime);
		}



	}

	void OnCollisionEnter (Collision obj){

		if(obj.gameObject.tag=="obstaculo"){
			transform.Rotate (Vector3.up,90);
		
		}

	}
}
