using UnityEngine;
using System.Collections;

public class instanciar_ladrones_policias : MonoBehaviour {
	public Transform[] l,posicion_policias;
	public Quaternion q;
	public Object la,po;

	// Use this for initialization
	void Start () {
		int n_ladrones=int.Parse(cargar_simulacion.l);
		int n_policias=int.Parse(cargar_simulacion.p);
	
			for(int i=1;i<=n_ladrones;i++){
				int p = Random.Range(0,l.Length-1);
				Instantiate(la,l[p].position,q);
			}
	
		for(int j=1;j<=n_policias;j++){
			int r = Random.Range(0,posicion_policias.Length-1);
			Instantiate(po,posicion_policias[r].position,q);
		}
	}
	

}
