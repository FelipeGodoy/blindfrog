using UnityEngine;
using System.Collections;

public class DestrMosca : MonoBehaviour {

	void OnTriggerExit(Collider collision){
		Destroy(collision.gameObject);
	}
}
