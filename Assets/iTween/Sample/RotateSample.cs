using UnityEngine;
using System.Collections;

public class RotateSample : MonoBehaviour
{	
	void Start(){
		iTween.RotateBy(gameObject, iTween.Hash("x", .3,"y",.3, "easeType", "easeInOutBack", "loopType", "loop", "delay", .4));
	}
}

