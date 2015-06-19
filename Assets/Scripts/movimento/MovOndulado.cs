using UnityEngine;
using System.Collections;

public class MovOndulado : MonoBehaviour {
	
	public float tempo = 20f;
	
	private float tempoRestanteDeVida;
		
	void Start(){
		tempoRestanteDeVida = tempo;
		iTween.MoveTo(gameObject,iTween.Hash("path",iTweenPath.GetPath("Movimento1"),"easeType","linear","time",tempo));
	}
	
	void FixedUpdate(){
		if(tempoRestanteDeVida <=0){
			DestroyImmediate(gameObject);
		}
		tempoRestanteDeVida-= Time.fixedDeltaTime;
	}
}
