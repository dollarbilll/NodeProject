using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

public class Network : MonoBehaviour {

    static SocketIOComponent socket;
    public GameObject playerPrefab;

	// Use this for initialization
	void Start () {

        socket = GetComponent<SocketIOComponent>();
        socket.On("open", OnConnected);
        socket.On("spawn", OnSpawned);
		
	}

    private void OnConnected(SocketIOEvent e)
    {
        Debug.Log("connected");
        socket.Emit("move");
    }

    void OnSpawned (SocketIOEvent e)
    {
        Instantiate(playerPrefab);
    }
}
