using UnityEngine;
using System.Collections;

public class EnviarDedoObject : MonoBehaviour {

	public float velocidadeMaxToque = .5f;
	private Vector2? posicaoAnterior = null;
	private AudioListener audioListener;
	public float tempoNascimentoProxMosca = 1f;
	
	void Awake(){
		audioListener = GetComponent<AudioListener>();
	}
	
	
	void FixedUpdate(){
		if(Input.GetMouseButton(0)){
			float velocidade;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			Vector2? point = null;
			int layerMosca = 1 << LayerMask.NameToLayer("Mosca");
			if(Physics.Raycast(ray,out hit,Mathf.Infinity,layerMosca)){
				audioListener.enabled = true;
				gameObject.transform.position = hit.point;
				point = new Vector2(hit.point.x, hit.point.y);
				if(posicaoAnterior == null){
					Handheld.Vibrate();
					Destroy(hit.collider.gameObject);
					NotificationCenter.DefaultCenter().PostNotification(this, "SetTempoParaNascer",tempoNascimentoProxMosca);
				}
				else{
					velocidade = Vector2.Distance(point.Value,posicaoAnterior.Value)/Time.fixedDeltaTime;
					if(velocidade <=velocidadeMaxToque){
						Handheld.Vibrate();
						Destroy(hit.collider.gameObject);
						NotificationCenter.DefaultCenter().PostNotification(this, "SetTempoParaNascer",tempoNascimentoProxMosca);
					}
				}
			}
			else
			if(Physics.Raycast(ray, out hit, Mathf.Infinity)){
				audioListener.enabled = true;
				gameObject.transform.position = hit.point;
				point = new Vector2(hit.point.x, hit.point.y);
			}
			else{
				audioListener.enabled = false;
				audio.volume = 0f;
			}
			posicaoAnterior = point;
		}
		else{
			audioListener.enabled = false;
			posicaoAnterior = null;
		}
	}
}
