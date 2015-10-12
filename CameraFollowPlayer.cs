using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
	Transform player;
	float offsetX;
	// Use this for initialization
	void Start () {
		GameObject playerGameObject = GameObject.FindGameObjectWithTag ("Player");
		if (playerGameObject == null) {
			Debug.Log ("Couldn't find GameObject with 'Player' tag");
			return;
		}
		//location of player
		player = playerGameObject.transform;
		offsetX = transform.position.x - player.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		//if Player is alive
		if (player != null) {
			Vector3 pos = transform.position;
			pos.x = player.position.x + offsetX;
			transform.position = pos;
		}
	}
}
