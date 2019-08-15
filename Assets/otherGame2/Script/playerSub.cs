using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerSub : MonoBehaviour {

    public float moveSpead = 5f;
    public float rotationSpeed = 360f;
    CharacterController characterController;
    public GameObject seal;
    public GameObject UI;
    public GameObject UI2;
    public GameObject angryBear;
    bool move = false;
    bool bearScale = false;
    
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (direction.sqrMagnitude > 0.01f)
        {
            Vector3 forward = Vector3.Slerp(
                transform.forward,
                direction,
                rotationSpeed * Time.deltaTime / Vector3.Angle(transform.forward, direction)
                );
            transform.LookAt(transform.position + forward);
        }
        characterController.Move(direction * moveSpead * Time.deltaTime);
        if (move && GameObject.Find("DaddyBear").transform.position.z >= -2)
        {
            GameObject.Find("DaddyBear").transform.Translate(0, 0, -0.03f);
        }
        if (bearScale)
        {
            angryBear.transform.localScale += new Vector3(2.3f, 2f, 2f);
            if(angryBear.transform.localScale.x >= 300)
            {
                bearScale = false;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "hole")
        {
            if (Random.Range(0, 2) == 0)
            {  // 먹이 먹음
                Instantiate(seal, new Vector3(-1, -2, -0.5f), Quaternion.Euler(0, 0, 0));
                UI2.SetActive(true);
                StartCoroutine(WaitSecond(2.0f));
                HealthBar.health += 10;
            }
            else
            {  //먹이없다..
                UI.SetActive(true);
                HealthBar.health -= 3;
            }
        }
        else if (other.tag == "bear")
        {
            if (Random.Range(0, 3) != 0)
            {
                Instantiate(seal);
                //먹이 들고있다
                UI2.SetActive(true);
                HealthBar.health += 10;
                StartCoroutine(WaitSecond(2f));
            }
            else
            {
                angerBear();
                //move = true;
                Invoke("toActive2", 3f);
                //아빠가 배고파서 화났다.
                HealthBar.health = 0.1f;
            }
        }
        else
        {
        }
    }

    void toActive()
    {
        UI2.SetActive(true);
    }

    void toActive2()
    {
        UI.SetActive(true);
    }

    void angerBear()
    {
        GameObject.Find("DaddyBear").SetActive(false);
        angryBear.SetActive(true);
        bearScale = true;
    }

    IEnumerator WaitSecond(float second)
    {
        yield return new WaitForSeconds(second);
        SceneManager.LoadScene("Main");
    }
    
}
