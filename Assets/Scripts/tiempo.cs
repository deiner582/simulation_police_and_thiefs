using UnityEngine;
using System.Collections;
using System.IO;
public class tiempo : MonoBehaviour {
	float tiemp;
	 public static int min=0;
	public UILabel l_tiempo;
	public UILabel cantidad_ladrones;
	private GameObject[] ladrones,policias;
	void Start(){
		ladrones=GameObject.FindGameObjectsWithTag("ladron");
		policias=GameObject.FindGameObjectsWithTag("policia");
		cantidad_ladrones.text=ladrones.Length.ToString();
	}


	void Update ()
	{

	tiemp+=Time.deltaTime;
	l_tiempo.text= min.ToString("00 : ")+Mathf.RoundToInt(tiemp).ToString("00");
	if (Mathf.RoundToInt(tiemp) == 60){
		min+=1;
		tiemp=0f;
	}
		if(l_tiempo.text=="05 : 00"){

			guardar();
		}

		if(l_tiempo.text=="05 : 01"){
			min=0;
			Application.LoadLevel("simulacion");

		}


}
	void guardar(){
		StreamWriter b=File.AppendText("D:/simulacion.txt");
		b.WriteLine(ladrones.Length.ToString()+";"+policias.Length.ToString()+";"+recorrerWayPoints.contar_ladrones+";"+l_tiempo.text);
		b.Close();
		
		
	}

	
}
