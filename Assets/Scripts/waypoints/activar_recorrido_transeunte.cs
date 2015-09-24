using UnityEngine;
using System.Collections;

public class activar_recorrido_transeunte : MonoBehaviour{

	IEnumerator Start ()
	{
		yield return new WaitForSeconds(0.1f);
		GetComponent<waypoint_transeunte>().enabled=true; 

	}
}

