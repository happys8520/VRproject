using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// EditorApplication.isPaused = true; 카메라 중지

//     this.transform.rotation = Quaternion.Euler(-90, 0, 0); 위로 화면 전환하는거.
// RightLeft.eulerAngles = new Vector3(-180, 0, 0);  // 화면이 위아래가 180도

public class moveXYZ : MonoBehaviour
{
    public static int cnt1 = 0;   // 첫번째 물고기 먹은 갯수
    public static int cnt2 = 0;   // 두번째 물고기 먹은 갯수
    public static int cnt3 = 0;   // 세번째 물고기 먹은 갯수

    public float Speed; //카메라 스피드
    bool flag = true;   // Gui 숨기기
    public GameObject CautionShampoo;
    public GameObject CautionDead;

    // 쿼리니언을 사용하여 회전하는 경우, 먼저 변수 선언
    private Quaternion RightLeft = Quaternion.identity;
    
    private void OnGUI()
    {
        if (flag)
        {
            GUI.Box(new Rect(50, 100, 300, 300), "\n게임설명"); // 박스 띄우기
            GUI.TextArea(new Rect(78, 140, 250, 225), "- 작은 물고기부터 순서대로 먹을 수 있습니다.\n" +
                "- 제일 작은 물고기 세마리이상을 먹고 나면\n" +
                "그 다음으로 큰 물고리를 먹을 수 있습니다. *\n\n" +
                "- 방향키를 통해 위,아래,좌,우를 둘러볼 수 있습니다.\n" +
                "- 왼쪽 Shift를 통해 뒤를 볼 수 있습니다.\n" +
                "- 뒤를 보게 될 경우에는 'w,s,a,d'순으로 '위,아래,좌,우'를 볼 수있습니다.\n" +
                "- 다시 앞의 화면을 보고싶을 경우에는 오른쪽 Shift키를 눌러주세요");
            if(GUI.RepeatButton(new Rect(78, 370, 250, 20), "'게임설명' 화면숨기기"))
            {
                flag = false;
            }
            //GUI.TextArea(new Rect(Screen.width * 0.01f, Screen.height / 2, 200, 20), "Screen을 이용한 위치설정");
        }
    }


    //-----------------------카메라가 물고기와 충돌 하는 경우-----------
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "shampoo")
        {
            Health.health -= 10f;
            CautionShampoo.SetActive(true);
            Invoke("CShampooFalse", 7f);
        }
    }
    // 샴푸 주의문  사라지게 하기
    void CShampooFalse()
    {
        CautionShampoo.SetActive(false);
    }

    // 쓰레기 먹은 물고기 경고문 사라지면서 동시에 씬전환
    void DeadFalse()
    {
        CautionDead.SetActive(false);
        SceneManager.LoadScene("resultBackground");
    }


    void OnTriggerStay(Collider other)
    {
        Vector3 cameraPosition = transform.position;
        Vector3 FishPosition = other.transform.position;
        float dis = Vector3.Distance(cameraPosition, FishPosition);

        //---첫번째 물고기
        if (other.tag == "firstFish")
        {
            if (this.transform.rotation == Quaternion.LookRotation(Vector3.left))
            {
                other.transform.rotation = Quaternion.Slerp(transform.rotation,
                                                    Quaternion.LookRotation(Vector3.left),
                                                    flock.rotationSpeed * Time.deltaTime);
                Speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                other.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                
                if ((-3 < dis) && (dis < 3))
                {
                    Debug.Log("destroy11!!!!!!!!!!!!");
                    Destroy(other.gameObject);
                    Health.health += 10f;
                    cnt1++;
                }
            }
            else
            {
                other.transform.rotation = Quaternion.Slerp(transform.rotation,
                                                    Quaternion.LookRotation(Vector3.right),
                                                    flock.rotationSpeed * Time.deltaTime);
                Speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                other.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                
                if ((-3 < dis) && (dis < 3))
                {
                    Debug.Log("destroy11!!!!!!!!!!!!");
                    Destroy(other.gameObject);
                    Health.health += 10f;
                    cnt1++;
                }
            }

        }


        //-----두번째 물고기
        else if (other.tag == "secondFish")
        {
            if (cnt1 < 3)
            {
                Vector3 vec = cameraPosition - FishPosition;
                vec.Normalize();
                other.transform.rotation = Quaternion.Slerp(transform.rotation,
                                                Quaternion.LookRotation(vec),
                                                flock.rotationSpeed * Time.deltaTime);
                Speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                other.transform.Translate(Vector3.forward * Speed * Time.deltaTime);


                //right
                if ((-3 < dis) && (dis < 3))
                {     
                }

            }
            else
            {
                if (this.transform.rotation == Quaternion.LookRotation(Vector3.left))
                {
                    other.transform.rotation = Quaternion.Slerp(transform.rotation,
                                                        Quaternion.LookRotation(Vector3.left),
                                                        flock.rotationSpeed * Time.deltaTime);
                    Speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    other.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                    //this.GetComponent<Animator>().speed = flock.speed;


                    if ((-1 < dis) && (dis < 1))
                    {
                        Debug.Log("sec__destroy11!!!!!!!!!!!!");
                        Destroy(other.gameObject);
                        Health.health += 10f;
                        cnt2++;
                    }
                }
                else
                {
                    other.transform.rotation = Quaternion.Slerp(transform.rotation,
                                                        Quaternion.LookRotation(Vector3.right),
                                                        flock.rotationSpeed * Time.deltaTime);
                    Speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    other.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                    //this.GetComponent<Animator>().speed = flock.speed;

                    if ((-1 < dis) && (dis < 1))
                    {
                        Debug.Log("sec__destroy11!!!!!!!!!!!!");
                        Destroy(other.gameObject);
                        Health.health += 10f;
                        cnt2++;
                    }
                }
            }
            
        }
        

        //-----세번째 물고기
        else if (other.tag == "thirdFish")
        {
            if (cnt2 < 3)
            {
                if (Vector3.Distance(FishPosition, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z)) < dis)
                {
                    other.transform.rotation = Quaternion.Slerp(transform.rotation,
                                                        Quaternion.LookRotation(Vector3.left),
                                                        flock.rotationSpeed * Time.deltaTime);
                    Speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    other.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                   
                    
                    //right
                    if ((-3 < dis) && (dis < 3))
                    {
                   //     EditorApplication.isPaused = true;
                    }
                }
                else if (Vector3.Distance(FishPosition, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1)) < dis)
                {
                    other.transform.rotation = Quaternion.Slerp(transform.rotation,
                                                        Quaternion.LookRotation(Vector3.back),
                                                        flock.rotationSpeed * Time.deltaTime);
                    Speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    other.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                    //forward
                    if ((-3 < dis) && (dis < 3))
                    {
                    //    EditorApplication.isPaused = true;
                    }
                }
                else if (Vector3.Distance(FishPosition, new Vector3(transform.position.x - 1, transform.position.y, transform.position.z)) < dis)
                {
                    other.transform.rotation = Quaternion.Slerp(transform.rotation,
                                                        Quaternion.LookRotation(Vector3.right),
                                                        flock.rotationSpeed * Time.deltaTime);
                    Speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    other.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                    // left
                    if ((-3 < dis) && (dis < 3))
                    {
                    //    EditorApplication.isPaused = true;
                    }
                }
                else if (Vector3.Distance(FishPosition, new Vector3(transform.position.x, transform.position.y, transform.position.z - 1)) < dis)
                {
                    other.transform.rotation = Quaternion.Slerp(transform.rotation,
                                                        Quaternion.LookRotation(Vector3.forward),
                                                        flock.rotationSpeed * Time.deltaTime);
                    Speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    other.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                    // back`
                    if ((-3 < dis) && (dis < 3))
                    {
                   //     EditorApplication.isPaused = true;
                    }
                }
                else if (Vector3.Distance(FishPosition, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z)) < dis)
                {
                    other.transform.rotation = Quaternion.Slerp(transform.rotation,
                                                        Quaternion.LookRotation(new Vector3(0, -90, 0)),
                                                        flock.rotationSpeed * Time.deltaTime);
                    Speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    other.transform.Translate(Vector3.forward * Speed * Time.deltaTime);

                    // back`
                    if ((-3 < dis) && (dis < 3))
                    {
                   //     EditorApplication.isPaused = true;
                    }
                }
                else if (Vector3.Distance(FishPosition, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z)) < dis)
                {
                    other.transform.rotation = Quaternion.Slerp(transform.rotation,
                                                        Quaternion.LookRotation(new Vector3(0, 90, 0)),
                                                        flock.rotationSpeed * Time.deltaTime);
                    Speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    other.transform.Translate(Vector3.forward * Speed * Time.deltaTime);

                    // back`
                    if ((-3 < dis) && (dis < 3))
                    {
                   //     EditorApplication.isPaused = true;
                    }
                }
            }
            else
            {
                if (this.transform.rotation == Quaternion.LookRotation(Vector3.left))
                {
                    other.transform.rotation = Quaternion.Slerp(transform.rotation,
                                                        Quaternion.LookRotation(Vector3.left),
                                                        flock.rotationSpeed * Time.deltaTime);
                    Speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    other.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                    //this.GetComponent<Animator>().speed = flock.speed;

                    if ((-3 < dis) && (dis < 3))
                    {
                        Debug.Log("destroy11!!!!!!!!!!!!");
                        Destroy(other.gameObject);
                        Health.health += 10f;
                        cnt3++;
                    }
                }
                else
                {
                    other.transform.rotation = Quaternion.Slerp(transform.rotation,
                                                        Quaternion.LookRotation(Vector3.right),
                                                        flock.rotationSpeed * Time.deltaTime);
                    Speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    other.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                    //this.GetComponent<Animator>().speed = flock.speed;

                    if ((-3 < dis) && (dis < 3))
                    {
                        Debug.Log("destroy11!!!!!!!!!!!!");
                        Destroy(other.gameObject);
                        Health.health += 10f;
                        cnt3++;
                    }
                }
            }
            
        }

        // -----------오염된 물고기 ----------------
        if (other.tag == "pollutedFish")
        {
            CautionDead.SetActive(true);
            Invoke("DeadFalse", 7f);
        }

    }
    
    
    //-----------방향키----------------------
    void Update()
    {
        if (Health.HealthBar.fillAmount <= 0)   // 체력바가 다 떨어지면 중지되고 중지된 이유 설명 및 버튼 생성
        {
            EditorApplication.isPaused = true;
            GUI.Box(new Rect(50, 100, 300, 300), "\n게임설명"); // 박스 띄우기

        }

        if (Input.GetKey(KeyCode.Space))    //직진  ---------------------
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }

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