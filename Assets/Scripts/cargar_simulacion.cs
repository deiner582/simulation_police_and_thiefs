using UnityEngine;
using System.Collections;

public class cargar_simulacion : MonoBehaviour {
	public UILabel tiempo,ladrones,policias;
	public static string t,l,p;
	// Use this for initialization
	void OnClick () {
		t=tiempo.text;
		l=ladrones.text;
		p=policias.text;
		Application.LoadLevel("simulacion");

	}
	

}
