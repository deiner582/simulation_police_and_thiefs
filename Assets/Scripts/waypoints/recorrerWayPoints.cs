using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;



public class recorrerWayPoints : MonoBehaviour {
	private Animator animator_ladron;
	private NavMeshAgent agente_ladron;
	public Transform[] ways;
	public Animator animator;
	bool ladron_vivo=true;
	private NavMeshAgent agente;
	private float distancia=100;
	private int i;
	public FOV2DEyes eyes;
	public float angulo_de_vision = 110f;    
	private SphereCollider col; 
	public static int contar_ladrones;
	public UILabel l_ladrones;
	public static bool atrapado=false;

	void Awake ()
	{
	
	
		contar_ladrones=0;
		//obtengo el componente nav mesh y sphere collider del gameobject que se le asignara el script
		agente=GetComponent<NavMeshAgent>();
		col = GetComponent<SphereCollider>();
		// valor aleatorio a i para cada policia
		i=Random.Range(0,ways.Length-1);
	}

	void Start(){
		agente.SetDestination(ways[i].position);
	}

	

	void Update () {
		//Asigna el punto de la ruta

		agente.SetDestination(ways[i].position);
		//Distancia entre el objeto y el WayPoint
		float distancia_waypoint=Vector3.Distance(transform.position,ways[i].position);
		//Si distancia es <= 3 y la variable i es menor al tamaño del array, pasa al siguiente waypoint, sino i sera igual a  0
		if(distancia_waypoint <=3 && i != ways.Length){
			//animator.SetBool("llego",true);
			i++;

		}
	
		if(i == ways.Length){

			i =Random.Range(0, ways.Length -1);
		}
	}



  void OnTriggerStay (Collider objecto)
	{
		//si el ladron entro en el sphere collider
		if(objecto.gameObject.tag=="ladron")
		{
			//obtiene el componente animator del Ladron
			animator_ladron = objecto.GetComponent<Collider>().GetComponent<Animator>();
			//obtiene el componente navmeshagent del ladron
			agente_ladron = objecto.GetComponent<Collider>().GetComponent<NavMeshAgent>();
			// Create a vector from the enemy to the player and store the angle between it and forward.
			Vector3 direccion = objecto.transform.position - transform.position;
			float angulo = Vector3.Angle(direccion,transform.forward);
			
			// If the angle between forward and where the player is, is less than half the angle of view...
			if(angulo < angulo_de_vision * 0.5f)
			{
				distancia = Vector3.Distance(transform.position, objecto.GetComponent<Collider>().transform.position);
			    agente.SetDestination(objecto.GetComponent<Collider>().transform.position);
			    animator.SetBool("correr",true);
				if(distancia<=3 && atrapado == false){
					contar_ladrones+=1;
					l_ladrones.text=contar_ladrones.ToString();
					animator_ladron.SetBool("morir",true);
					objecto.gameObject.tag="muerto";
					objecto.GetComponent<SphereCollider>().enabled=false;
					agente_ladron.Stop();
					agente_ladron.speed = 0;
				
				}

			}
		

		}	else{
			animator.SetBool("correr",false);
			atrapado=false;
		}

	}


}

