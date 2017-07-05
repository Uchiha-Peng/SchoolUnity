using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	private Transform m_people;
	private Rigidbody m_body;
	// Use this for initialization
	void Start () {
		m_people = gameObject.GetComponent<Transform> ();
		m_body=gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)) {
			m_body.MovePosition (m_people.position+Vector3.forward*0.05f);
			//m_people.Translate (Vector3.forward*0.1f,Space.World);
		}

		if (Input.GetKey(KeyCode.DownArrow)) {
			m_body.MovePosition (m_people.position+Vector3.back*0.05f);
			//m_people.Translate (Vector3.back*0.1f,Space.World);
		}

		if (Input.GetKey(KeyCode.LeftArrow)) {
			m_body.MovePosition (m_people.position+Vector3.left*0.05f);
			//m_people.Translate (Vector3.left*0.1f,Space.World);
		}

		if (Input.GetKey(KeyCode.RightArrow)) {
			m_body.MovePosition (m_people.position+Vector3.right*0.05f);
			//m_people.Translate (Vector3.right*0.1f,Space.World);
		}
	}
}
