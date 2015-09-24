using UnityEngine;
using System.Collections;

public class precargar_biologia : MonoBehaviour {
	private AsyncOperation LoadLevel;

	public UILabel porcentaje;
	public UISlider por;
	//int es;

	
	void Start () {
		//es=esc.OnClick();
		//print(es);



			LoadLevel=Application.LoadLevelAsync("simulacion");
			LoadLevel.allowSceneActivation=false;



	
	}
	

	void Update () {


		por.value=LoadLevel.progress;
		if(LoadLevel.progress==0.9f){
			por.value=90;
			porcentaje.text="90";
			//yield return new WaitForSeconds(2f);
			porcentaje.text="100";
			LoadLevel.allowSceneActivation=true;

		}
		

		
		
	}


	/* void OnClick(){
		if(LoadLevel.progress==0.9f){
			

		}
	} */
	
}    