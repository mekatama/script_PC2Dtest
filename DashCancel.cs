using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashCancel : MonoBehaviour{
	public GameObject objBPC;						//PlatformerMotor2D.csをアッタチしているオブジェクト用
	private PlatformerMotor2D scrPlatformerMotor2D;	//PlatformerMotor2D.csスクリプト入れる用

	void Start(){
		scrPlatformerMotor2D = objBPC.GetComponent<PlatformerMotor2D>();
	}

	void Update(){
//		Debug.Log((int)scrPlatformerMotor2D.collidingAgainst);
//		Debug.Log((int)scrPlatformerMotor2D.motorState);

		//dash中に接地判定がoffになったらdash cancel
		if((int)scrPlatformerMotor2D.collidingAgainst == 0 && (int)scrPlatformerMotor2D.motorState == 7){
			Debug.Log("dash off");
			scrPlatformerMotor2D.EndDash();

		}
	}
}
