using UnityEngine;
using System.Collections;

public class activar_recorrido : MonoBehaviour
{

		// Use this for initialization
		IEnumerator Start ()
		{
		yield return new WaitForSeconds(0.1f);
		GetComponent<recorrerWayPoints>().enabled=true;  
	}
	
		// Update is called once per frame

}

