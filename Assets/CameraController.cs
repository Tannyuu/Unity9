using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform player;

	void LateUpdate()
	{
		/*
		transform.position = player.position + (-player.forward * 3.0f) + (player.up * 1.0f);
		transform.LookAt(player.position + Vector3.up);
		*/


		transform.position =
			Vector3.Lerp(transform.position,
			player.position + (-player.forward * 3.0f)
			+ (player.up * 1f), Time.deltaTime * 10f);

		transform.LookAt(player.position + Vector3.up);//Lookat　z軸を向けるメソッド  Vector3.up　Unityちゃんの中心からy軸+1
	}
}