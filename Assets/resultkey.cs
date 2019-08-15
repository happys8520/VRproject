using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resultkey : MonoBehaviour {

    // 쿼리니언을 사용하여 회전하는 경우, 먼저 변수 선언
    private Quaternion RightLeft = Quaternion.identity;

    void OnGUI()
    {
        
    }


    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.RightShift))    // 앞면 보기 --------------------------------------------
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RightLeft.eulerAngles = new Vector3(0, -90, 0);  // 값 할당
            transform.rotation = Quaternion.Slerp(transform.rotation, RightLeft, Time.deltaTime * 2.0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RightLeft.eulerAngles = new Vector3(0, 90, 0);  // 값 할당
            transform.rotation = Quaternion.Slerp(transform.rotation, RightLeft, Time.deltaTime * 2.0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            RightLeft.eulerAngles = new Vector3(-90, 0, 0);  // 값 할당
            transform.rotation = Quaternion.Slerp(transform.rotation, RightLeft, Time.deltaTime * 2.0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            RightLeft.eulerAngles = new Vector3(90, 0, 0);  // 값 할당
            transform.rotation = Quaternion.Slerp(transform.rotation, RightLeft, Time.deltaTime * 2.0f);
        }

        if (Input.GetKey(KeyCode.LeftShift))    // 뒷면 보기 ----------------------------------------------------
        {
            transform.rotation = Quaternion.LookRotation(Vector3.back);
        }
        if (Input.GetKey(KeyCode.D))
        {
            RightLeft.eulerAngles = new Vector3(0, -90, 0);  // 오른쪽
            transform.rotation = Quaternion.Slerp(transform.rotation, RightLeft, Time.deltaTime * 2.0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            RightLeft.eulerAngles = new Vector3(0, 90, 0);  // 왼쪽
            transform.rotation = Quaternion.Slerp(transform.rotation, RightLeft, Time.deltaTime * 2.0f);
        }
        //- 문제 생김
        if (Input.GetKey(KeyCode.W))
        {
            RightLeft.eulerAngles = new Vector3(270, 0, 0);  // 값 할당
            transform.rotation = Quaternion.Slerp(transform.rotation, RightLeft, Time.deltaTime * 2.0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            RightLeft.eulerAngles = new Vector3(-270, 0, 0);  // 값 할당
            transform.rotation = Quaternion.Slerp(transform.rotation, RightLeft, Time.deltaTime * 2.0f);
        }
    }
}
