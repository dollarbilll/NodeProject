using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenClicker : MonoBehaviour {

    Camera cam;
   
   
	// Use this for initialization
	void Start () {
        cam = GetComponent<Camera>();
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown ("Fire2"))
            Clicked();
           
	}

    public void Clicked()
    {
        Ray ray = cam.ScreenPointToRay (Input.mousePosition);

        RaycastHit hit = new RaycastHit();

        if(Physics.Raycast(ray, out hit))
        {

             var clickMove = hit.collider.gameObject.GetComponent<ClickMove>();
                clickMove.OnClick(hit.point);
        }

    }
}
