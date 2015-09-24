using UnityEngine;
using System.Collections;

public class distancia : MonoBehaviour {
	public GameObject pol;
   public GameObject ladron;
	int dist;
	public WaypointManager waypointManager;
	public Animator a_pol,a_ladron;

	//public FOV2DEyes eyes;
	// Use this for initialization
	void Start () {
		//ladron=GameObject.FindGameObjectWithTag("ladron");
	}
	
	// Update is called once per frame
	void Update () {
		dist=Mathf.RoundToInt(Vector3.Distance(pol.transform.position,ladron.transform.position));
		print(dist);

		if(dist<=8){
			this.gameObject.transform.Translate(Vector3.forward*Time.deltaTime*5,ladron.transform);
			//a_ladron.SetFloat("salud",0.01f);


		}

	

	}
	/*void OnTriggerStay (Collider other)
	{
		if (other.gameObject.tag == "ladron")
		{

			Vector3 shootTo = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z);
			Vector3 shootFrom = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
			Vector3 rayDirection = shootTo - shootFrom;
			RaycastHit hit;

		    Debug.DrawLine (shootFrom, rayDirection, Color.yellow, 3);
			if(Physics.Raycast(shootFrom, rayDirection,10))
			{
				Debug.DrawLine (shootFrom, hit.collider.gameObject.transform.position, Color.cyan, 3);
				print ("Hit: " + hit.collider.gameObject.transform.name);
				if(hit.collider.gameObject.tag == "ladron")
				{
					print("Player found");
				}
			}
			}
		}*/
	//	void StatusUpdate(){
	//	foreach(RaycastHit hit in eyes.hits) 
	//	{
	//		if (hit.transform.tag=="ladron") 
	//		{
	//			a_pol.SetBool("VioLadron",true);
	//		}

	//	}
	//	}

	}

