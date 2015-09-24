using UnityEngine;
using System.Collections;

public class mecanimLadron : MonoBehaviour
{
	public Animator animator;
	float salud=2.0f,tiempo;
	int ladron=0;
	public UILabel l_ladron;
		// Use this for initialization
	void Start ()
	{
		
		}
	
		// Update is called once per frame
		void Update ()
		{
		l_ladron.text=ladron.ToString();
		tiempo+=Time.deltaTime;
		if((Mathf.RoundToInt(tiempo))%3==0){
			salud=salud-0.5f;
			animator.SetFloat("salud",salud);
			if(salud<0.1f){
				//ladron+=1;
			}
		}
	}
}

