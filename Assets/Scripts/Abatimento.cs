using UnityEngine;
using System.Collections;

public class Abatimento : MonoBehaviour {
	
	public float velocidadeMaxToque;
	
	private Vector3 posicaoAnterior;
		
	void FixedUpdate () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		int layerMosca = 1 << LayerMask.NameToLayer("Mosca");
		if(Physics.Raycast(ray,Mathf.Infinity,layerMosca)){
			Handheld.Vibrate();
			audio.volume = 1f;
		}
//		if(posicaoAnterior == null){
//			
//		}
	}
}
