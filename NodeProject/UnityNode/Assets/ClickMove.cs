using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMove : MonoBehaviour {

    public GameObject player;
    public Vector3 position;

	// Update is called once per frame
	public void OnClick (Vector3 position) {
        var navPos = player.GetComponent<NavigatePosition>();
        navPos.NavigateTo(position);
	}
}
