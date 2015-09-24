using UnityEngine;
using System.Collections;

public class waypoint_ladron : MonoBehaviour {
	private NavMeshAgent ladron;
	public Transform[] caminos;
	public Transform[] refugios;
	private int i;
	private Animator l_animator; 
	private bool morir=false;
	private static bool es;
	public float angulo_de_vision = 110f;  
	private bool vio_policia=false;
	public int[] distancias;
	int menor_distancia;
	private int j;
	void Awake()
	{
	
		//obtengo el componente nav mesh y sphere collider del gameobject que se le asignara el script
		l_animator=GetComponent<Animator>();
		ladron=GetComponent<NavMeshAgent>();
		i=Random.Range(0,caminos.Length-1);

		//le doy un valor aleatorio a i para cada transeunte de 0 a al cantidad de puntos definos en el editor
	}

	void Start(){
		ladron.SetDestination(caminos[i].position);
	}
	

	void Update () {
		ladron.SetDestination(caminos[i].position);
		float distancia=Vector3.Distance(transform.position,caminos[i].position);
		//se dirige hacia el primer punto que tenga i
		if(recorrerWayPoints.atrapado==false && vio_policia==false){

			if((distancia<=2)&&(i!=caminos.Length)){
				i=i+1;
			}
				
			if(i==caminos.Length){
				l_animator.SetBool("llego",true);
				i=0;
				ladron.speed=0f;
				this.gameObject.tag="llego";
			}
	}
}

	void OnTriggerStay (Collider objecto)
	{
		//si el ladron entro en el sphere collider
		if(objecto.gameObject.tag=="policia")
		{

			// Create a vector from the enemy to the player and store the angle between it and forward.
			Vector3 direccion = objecto.transform.position - transform.position;
			float angulo = Vector3.Angle(direccion,transform.forward);
			
			// If the angle between forward and where the player is, is less than half the angle of view...
			if(angulo < angulo_de_vision * 0.5f)
			{
				vio_policia=true;
					
				}
				
			}
		else{
			vio_policia=false;
		}
			
			
		}	
		

	}
	


