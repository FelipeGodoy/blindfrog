using UnityEngine;
using System.Collections;

public class InteracaoMosca : MonoBehaviour {
	
	private AudioSource audio;
	private GameObject gameObjectDedo;
	
	public Spawn spawn;
	
	public float tempoNascimentoProxMosca = 1f;
	
	public float velocidadeMaxToque = .5f;
	private Vector2? posicaoAnterior = null;
	
	private AudioListener audioListener;
	
	public void SetGameObjectDedo(Notification notification){
		gameObjectDedo = (GameObject)notification.data;
		audioListener = gameObjectDedo.GetComponent<AudioListener>();
	}
	void Awake(){
//		NotificationCenter.DefaultCenter().AddObserver(this,"SetGameObjectDedo");
		gameObjectDedo = GameObject.Find("PosToque");
		audio = GetComponent<AudioSource>();
		audio.loop = true;
	}
	
	
	
//	void FixedUpdate () {
//		if(Input.GetMouseButton(0)){
//			float velocidade;
//			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//			RaycastHit hit;
//			Vector2? point = null;
//			int layerMosca = 1 << LayerMask.NameToLayer("Mosca");
//			if(Physics.Raycast(ray,out hit,Mathf.Infinity,layerMosca)){
////				audioListener.enabled = true;
//				audio.volume = 1f;
//				gameObjectDedo.transform.position = hit.point;
//				point = new Vector2(hit.point.x, hit.point.y);
//				if(posicaoAnterior == null){
//					Handheld.Vibrate();
//					Destroy(gameObject);
////					spawn.SetTempoParaNascer(tempoNascimentoProxMosca);
//					NotificationCenter.DefaultCenter().PostNotification(this, "SetTempoParaNascer",tempoNascimentoProxMosca);
//				}
//				else{
//					velocidade = Vector2.Distance(point.Value,posicaoAnterior.Value)/Time.fixedDeltaTime;
//					if(velocidade <=velocidadeMaxToque){
//						Handheld.Vibrate();
//						Destroy(gameObject);
////						spawn.SetTempoParaNascer(tempoNascimentoProxMosca);
//						NotificationCenter.DefaultCenter().PostNotification(this, "SetTempoParaNascer",tempoNascimentoProxMosca);
//					}
//				}
//			}
//			else
//			if(Physics.Raycast(ray, out hit, Mathf.Infinity)){
////				audioListener.enabled = true;
//				audio.volume = 1f;
//				gameObjectDedo.transform.position = hit.point;
//				point = new Vector2(hit.point.x, hit.point.y);
//			}
//			else{
//				audio.volume = 0f;
////				audioListener.enabled = false;
//			}
//			posicaoAnterior = point;
//		}
//		else{
//			audio.volume = 0f;
//			posicaoAnterior = null;
//		}
//	}
}
