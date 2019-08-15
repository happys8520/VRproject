using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

    public float moveSpead = 5f;
    public float rotationSpeed = 360f;
    CharacterController characterController;
    public GameObject dis;
    public GameObject pan;
    bool staCheck = true;

    

    // Use this for initialization
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Instantiate(pan, new Vector3(0, 0.2f, 0), Quaternion.Euler(0, 0, 0));
        Instantiate(dis, new Vector3(0, 0, -1), Quaternion.Euler(0, 0, 0));
        }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 tmp = new Vector3(Input.GetAxis("Horizontal"), 0);
        if (direction.sqrMagnitude > 0.01f)
        {
            Vector3 forward = Vector3.Slerp(
                transform.forward,
                direction,
                rotationSpeed * Time.deltaTime / Vector3.Angle(transform.forward, direction)
                );
            transform.LookAt(transform.position + forward);
        }
        characterController.Move(tmp * moveSpead * Time.deltaTime);
        if (HealthBar.health <= 0 && staCheck)
        {
            noHealth.status++;
            staCheck = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "dis")
        {
            Destroy(other.gameObject);
            Instantiate(pan, new Vector3(0, 0.2f, 0), Quaternion.Euler(0, 0, 0));
            Instantiate(dis, new Vector3(0, 0, -1), Quaternion.Euler(0, 0, 0));
            GameObject.Find("Spawner").GetComponent<RandomOb>().UseFun();
        }
        if(other.tag == "hole")
        {
            SceneManager.LoadScene("hole");
        }
        if(other.tag == "bear")
        {
            SceneManager.LoadScene("daddy");
        }
        if (other.tag == "empty")
        {
            SceneManager.LoadScene("empty");
        }
    }
}
