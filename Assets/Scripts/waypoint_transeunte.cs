using UnityEngine;
using System.Collections;

public class waypoint_transeunte : MonoBehaviour {
	NavMeshAgent transeunte;
	public Transform[] caminos;
	private int i;
	private bool u_waypoint=false;
	// Use this for initialization
	
	void Awake ()
	{
		//obtengo el componente nav mesh y sphere collider del gameobject que se le asignara el script
		transeunte=GetComponent<NavMeshAgent>();
		//le doy un valor aleatorio a i para cada transeunte de 0 a al cantidad de puntos definos en el editor
		i=Random.Range(0,caminos.Length);	
	}


	void Update () {
	
		//se dirige hacia el primer punto que tenga i

		transeunte.SetDestination(caminos[i].position);
		float distancia=Vector3.Distance(caminos[i].position,transform.position);
		if(i==caminos.Length-1){
			u_waypoint=true;
		}else{
			u_waypoint=false;
		}

		if(distancia<=3 && u_waypoint==false){
			i++;
		}
		if(distancia<=3 && u_waypoint==true){
			i=Random.Range(0,caminos.Length);
		}
		//if(distancia<=1)
			
	//7	{
			//transeunte.nextPosition=caminos[i].position;
			//i=i+1;
	//	}


	}

		//si llego al waypoint entonces seguiremos al siguiente
	
			//si esta en el ultimo waypoint reinicio el contador en 0
		/*	if(i == caminos.Length-1){
			i=Random.Range(0,caminos.Length-1);

		

		}else{
			if(distancia<=1)
			                                                                  
			{
				transeunte.nextPosition=caminos[i].position;
				i=i+1;
			}
		}
		}*/
		
	}

