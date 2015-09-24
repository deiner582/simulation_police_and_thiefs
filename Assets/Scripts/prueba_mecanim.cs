using UnityEngine;
using System.Collections;

public class prueba_mecanim : MonoBehaviour {
	public Animator animator;
	float tiempo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tiempo+=Time.deltaTime;
		if((Mathf.RoundToInt(tiempo))>10){
			animator.SetBool("VioLadron",true);
		}
		if((Mathf.RoundToInt(tiempo))>20){
			animator.SetBool("VioLadron",false);
		}

	}
}
