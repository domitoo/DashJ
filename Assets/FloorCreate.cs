using UnityEngine;
using System.Collections;

public class FloorCreate : MonoBehaviour {
	Vector3 Pos;
	public GameObject FloorBlock;
	GameObject nowGround;
	private CharacterController m_CharacterController;
	bool otherGround = true;




	// Use this for initialization
	void Start () {
		m_CharacterController = GetComponent<CharacterController>();
		//Pos = this.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		//float Dis = Vector3.Distance(Pos,this.transform.position);
	//	if(m_CharacterController.isGrounded){

		if(!otherGround){
			int plusX = Random.Range(35,45);
			int plusY = Random.Range(-20,0);
			int plusZ = Random.Range(-20,20);


				Vector3 createPos = new Vector3(this.transform.position.x + plusX, this.transform.position.y -10f + plusY,this.transform.position.z + plusZ);
				Instantiate(FloorBlock,createPos,Quaternion.identity);
				Pos = this.transform.position;
				otherGround = true;

		}
	
	}

	private void OnControllerColliderHit(ControllerColliderHit hit){
		if (nowGround != hit.gameObject) {
			otherGround = false;
		}

		nowGround = hit.gameObject;
	
	}
}
