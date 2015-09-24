using UnityEngine;
using System.Collections;
using System.IO;
public class guardar_escenario : MonoBehaviour {

	// Use this for initialization
	void Start () {
		guardar();
	}
	

	
	void guardar(){
		StreamWriter b=File.AppendText(Application.persistentDataPath + "/simulacion.txt");
		b.WriteLine(recorrerWayPoints.contar_ladrones+";"+ tiempo.min.ToString());
		b.Close();
		
		
	}
}
