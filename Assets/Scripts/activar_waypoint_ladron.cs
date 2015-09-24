using UnityEngine;
using System.Collections;

public class activar_waypoint_ladron : MonoBehaviour
{

	IEnumerator Start ()
	{
		yield return new WaitForSeconds(0.1f);
		GetComponent<waypoint_ladron>().enabled=true;  

	}
}


