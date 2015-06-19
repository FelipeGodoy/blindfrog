using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	
	public GameObject mosca;
	
	public GameObject posSpawn2;
	
	public GameObject[] prefabsMoscas;
	private GameObject[] moscasNaTela;
	private int idxMoscasNaTela;
	
	public float spawnTempo = 4f;
	
	public float tempoRestante;
	private float proxTempo = 0;
	private int cont = 0;
	
	void Awake () {
		NotificationCenter.DefaultCenter().AddObserver(this,"SetTempoParaNascer");
		tempoRestante = 0;
		if(mosca == null)
			enabled = false;
	}
	
	void FixedUpdate(){
		if (Input.GetKeyDown(KeyCode.Escape)){ 
			Application.Quit();
		}
		if(proxTempo != 0){
			tempoRestante = proxTempo;
			proxTempo = 0;
		}
		tempoRestante -= Time.fixedDeltaTime;
		if(tempoRestante <=0){
			CriarMosca();
		}
	}
	
	public void CriarMosca(){
		GameObject novaMosca = (GameObject)Instantiate(mosca,transform.position,transform.rotation);
		novaMosca.name = "Mosca" + cont++;
		Vector2 novaPosicao = new Vector2(transform.position.x,Random.Range(transform.position.y,
																			posSpawn2.transform.position.y));
		novaMosca.transform.position = novaPosicao;
		novaMosca.transform.position = novaPosicao;
		novaMosca.rigidbody.AddForce(new Vector3(1f,0,0),ForceMode.VelocityChange);
//			novaMosca.AddComponent<MovOndulado>();
		tempoRestante = spawnTempo;
	}
	
	public void SetTempoParaNascer(Notification notification){
		tempoRestante = (float)notification.data;
	}
	
	public void SetTempoParaNascer(float tempo){
		proxTempo = tempo;
	}
}
