using System.Collections;
using UnityEngine;

// X는-10~ 60
//  Y -0.5~10
// Z는 -25 ~ 50

public class flock : MonoBehaviour
{
    public static float speed = 0.1f;
    public static float rotationSpeed = 1.0f;
    public static float minSpeed = 0.5f;
    public static float maxSpeed = 1.0f;
    Vector3 averageHeading;
    Vector3 averagePosition;
    //float neighbourDistance = 3.0f;
    public Vector3 newGoalPos;  // 목표거리

    public bool turning = false;

    // Use this for initialization
    void Start()
    {
         speed = Random.Range(minSpeed, maxSpeed);
        this.GetComponent<Animator>().speed = speed;
    }
    
    // Update is called once per frame
    void Update()
    {

        Vector3 direction = newGoalPos - transform.position;
        transform.rotation = Quaternion.Slerp(transform.rotation,
                                                Quaternion.LookRotation(direction),
                                                rotationSpeed * Time.deltaTime);

        speed = Random.Range(minSpeed, maxSpeed);
        this.GetComponent<Animator>().speed = speed;
        transform.Translate(Time.deltaTime * -speed, 0, 0);

        Vector3 fishPosition = this.transform.position;

        
        //----------------면--------------------
        if (fishPosition.x < 60 && fishPosition.x > -10 &&
            fishPosition.y > -6 && fishPosition.y < 10 && fishPosition.z > 50) // x,y는 범위내이고 z는 +로벗어남.
        {
            int num = Random.Range(1, 10);
            switch (num)
            {
                case 1:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                                    Quaternion.LookRotation(Vector3.left),
                                                    flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;

                case 2:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                                    Quaternion.LookRotation(Vector3.right),
                                                    flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;

                case 3:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                                    Quaternion.LookRotation(Vector3.back),
                                                    flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;

                case 4:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                                    Quaternion.LookRotation(Vector3.left + Vector3.back),
                                                    flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;

                case 5:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                                    Quaternion.LookRotation(Vector3.back + Vector3.right),
                                                    flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 6:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                                    Quaternion.LookRotation(new Vector3(0, 90, 0)),
                                                    flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 7:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                                    Quaternion.LookRotation(new Vector3(0,45, -45)),
                                                    flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime); break;
                case 8:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                                    Quaternion.LookRotation(new Vector3(0,-90,0)),
                                                    flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime); break;
                case 9:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                                    Quaternion.LookRotation(new Vector3(0, -45, -45)),
                                                    flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime); break;
            }
        }
        if (fishPosition.x < 60 && fishPosition.x > -10 &&
            fishPosition.y > -6 && fishPosition.y < 10 && fishPosition.z < -25) // x,y는 범위내이고 z는 -로벗어남.
        {
            int num = Random.Range(1, 10);
            switch (num)
            {
                case 1:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.left),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 2:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.right),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;

                case 3:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.forward),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 4:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.forward + Vector3.left),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 5:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.forward + Vector3.right),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 6:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(new Vector3(0, 90, 0)),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 7:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(new Vector3(0, 45, 45)),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 8:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(new Vector3(0, -90, 0)),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 9:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(new Vector3(0, -45, 45)),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
            }
        }
        if (fishPosition.z < 50 && fishPosition.z > -25 &&
            fishPosition.y > -6 && fishPosition.y < 10 && fishPosition.x > 60) // z,y는 범위내이고 x는 +로 벗어남.
        {
            int num = Random.Range(1, 10);
            switch (num)
            {
                case 1:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.left),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 2:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.back),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 3:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.forward),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 4:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.forward + Vector3.left),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 5:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.back + Vector3.left),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 6:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(new Vector3(0, 90, 0)), // 수직으로 올라가기
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 7:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(new Vector3(-45, 45, -45)),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 8:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(new Vector3(0, -90, 0)),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 9:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                         Quaternion.LookRotation(new Vector3(-45, -45, -45)),
                                         flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
            }
        }
        if (fishPosition.z < 50 && fishPosition.z > -25 && fishPosition.x < -10 &&
            fishPosition.y > -6 && fishPosition.y < 10) // z,y는 범위내이고 x는 -로 벗어남.
        {
            int num = Random.Range(1, 6);
            switch (num)
            {
                case 1:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.back),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 2:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.right),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 3:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.forward),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 4:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.back + Vector3.right),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 5:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.forward + Vector3.right),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 6:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(new Vector3(0, 90, 0)),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 7:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(new Vector3(45, 45, 0)),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 8:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(new Vector3(0, -90, 0)),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 9:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(new Vector3(45, -45, 0)),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
            }
        }
        if (fishPosition.z < 50 && fishPosition.z > -25 &&
            fishPosition.x > -10 && fishPosition.x < 60 && fishPosition.y > 10) // z,x는 범위내이고 y는 +로 벗어남. (내려가거나 양옆 앞뒤)
        {
            int num = Random.Range(1, 10);
            switch (num)
            {
                case 1:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.left),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 2:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.back),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 3:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.forward),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 4:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.forward + Vector3.left),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 5:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.back + Vector3.left),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 6:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.right),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 7:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.forward + Vector3.right),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 8:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(new Vector3(0, -90, 0)),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 9:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(new Vector3(-45, -45, -45)),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
            }
        }
        if (fishPosition.z < 50 && fishPosition.z > -25 && fishPosition.y < -6 &&
            fishPosition.x > -10 && fishPosition.x < 60) // z,x는 범위내이고 y는 -로 벗어남.
        {
            int num = Random.Range(1, 6);
            switch (num)
            {
                case 1:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.back),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 2:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.right),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 3:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.forward),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 4:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                             Quaternion.LookRotation(Vector3.right + Vector3.back),
                                             flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 5:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.forward + Vector3.right),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 6:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(new Vector3(0, 90, 0)),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 7:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(new Vector3(45, 45, 0)),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 8:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.left),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 9:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.forward + Vector3.left),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
            }
        }

        //---------------------------------------------선--------------------------------------------------------
        //-----Y(|)
        if (fishPosition.z < -25 && fishPosition.x < -10 &&
            fishPosition.y > -6 && fishPosition.y < 10) // y는 범위내에 z, x 모두가 -로 벗어나는 모서리(앞,오른쪽으로 이동 가능)
        {
            int num = Random.Range(1, 8);
            switch (num)
            {
                case 1:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.forward),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 2:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.right),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 3:
                    transform.rotation = Quaternion.Slerp(transform.rotation,
                                            Quaternion.LookRotation(Vector3.forward + Vector3.right),
                                            flock.rotationSpeed * Time.deltaTime);
                    speed = Random.Range(flock.minSpeed, flock.maxSpeed);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, 90, 0)); // 수직으로 올라가기
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(45, 45, 45));   // 사선으로 올라가기
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, -90, 0));   // 수직으로 내려가기
                    break;
                case 7:
                    transform.rotation = Quaternion.LookRotation(new Vector3(45, -45, 45));    // 사선으로 내려가기
                    break;
            }
        }
        if (fishPosition.z > 50 && fishPosition.x > 60 &&
            fishPosition.y > -6 && fishPosition.y < 10) // y는 범위내에 z, x 모두가 +로 벗어나는 모서리 (뒤로, 왼쪽으로 이동 가능)
        {
            int num = Random.Range(1, 8);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back);
                    break;

                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.left);
                    break;

                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back + Vector3.left);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, 90, 0)); // 수직으로 올라가기
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(-45, 45, -45));   //사선으로 올라가기
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, -90, 0));   // 수직으로 내려가기
                    break;
                case 7:
                    transform.rotation = Quaternion.LookRotation(new Vector3(-45, -45, -45));    // 사선으로 내려가기
                    break;
            }
        }
        if (fishPosition.z > 50 && fishPosition.x < -10 &&
            fishPosition.y > -6 && fishPosition.y < 10) // y는 범위내에 z는 +로,  x는 -로 벗어나는 모서리 (뒤, 오른쪽으로 이동 가능)
        {
            int num = Random.Range(1, 8);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back);
                    break;

                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.right);
                    break;

                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back + Vector3.right);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, 90, 0)); // 수직으로 올라가기
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(45, 45, -45));   //사선으로 올라가기(-135 아님 -45)
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, -90, 0));   // 수직으로 내려가기
                    break;
                case 7:
                    transform.rotation = Quaternion.LookRotation(new Vector3(45, -45, -45));    // 사선으로 내려가기(135 아님 45)
                    break;
            }
        }
        if (fishPosition.z < -25 && fishPosition.x > 60 &&
            fishPosition.y > -6 && fishPosition.y < 10) // y는 범위내에 z는 -로,  x는 +로 벗어나는 모서리 (앞, 왼쪽으로 이동 가능)
        {
            int num = Random.Range(1, 8);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward);
                    break;

                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.left);
                    break;

                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward + Vector3.left);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, 90, 0)); // 수직으로 올라가기
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(-45, 45, 45));   //사선으로 올라가기(-135 아님 -45)
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, -90, 0));   // 수직으로 내려가기
                    break;
                case 7:
                    transform.rotation = Quaternion.LookRotation(new Vector3(-45, -45, 45));    // 사선으로 내려가기(135 아님 45)
                    break;
            }
        }
        //------X(ㅡ)
        if (-10 < fishPosition.x && fishPosition.x < 60 &&
            fishPosition.y < -6 && fishPosition.z < -25)   //x범위내에 y,z 모두가 -로 벗어나는 선 전체 (뒤, 아래 x)
        {
            int num = Random.Range(1, 7);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward);
                    break;

                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.right);
                    break;

                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward + Vector3.right);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, 90, 0)); // 수직으로 올라가기
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, 45, 45));   // 사선으로 올라가기
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(-45, 45, 45));     //왼쪽 위 사선으로 올라가기
                    break;
            }
        }
        if (-10 < fishPosition.x && fishPosition.x < 60 &&
            fishPosition.y > 10 && fishPosition.z > 50)   //x범위내에 y,z 모두가 +로 벗어나는 선 전체 (위, 앞 x)
        {
            int num = Random.Range(1, 8);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back);
                    break;

                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.left);
                    break;

                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back + Vector3.left);
                    break;
                case 4:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.right);
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, -90, 0));   // 수직으로 내려가기
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, -45, -45));    // 사선으로 내려가기
                    break;
                case 7:
                    this.transform.rotation = Quaternion.LookRotation(new Vector3(-45, -45, -45));
                    break;
            }
        }
        if (-10 < fishPosition.x && fishPosition.x < 60 &&
            fishPosition.y < -6 && fishPosition.z > 50)   //x범위내에 y:-, z:+  벗어나는 선 전체(앞, 아래x)
        {
            int num = Random.Range(1, 7);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back);
                    break;
                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.left);
                    break;
                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back + Vector3.left);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, 90, 0)); // 수직으로 올라가기
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, 45, -45));   //사선으로 올라가기
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(45, 45, -45));
                    break;
            }
        }
        if (-10 < fishPosition.x && fishPosition.x < 60 &&
            fishPosition.y > 10 && fishPosition.z < -25)   //x범위내에 y:+ ,z:- 로 벗어나는 선 전체 (위, 뒤 x)
        {
            int num = Random.Range(1, 10);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward);
                    break;
                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.left);
                    break;
                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward + Vector3.left);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(Vector3.forward + Vector3.right);
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(Vector3.right);
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, -90, 0));   // 수직으로 내려가기
                    break;
                case 7:
                    transform.rotation = Quaternion.LookRotation(new Vector3(-45, -45, 45));    // 사선으로 내려가기(135 아님 45)
                    break;
                case 9:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, -45, 45));
                    break;
            }
        }
        //--------Z
        if (-25 < fishPosition.z && fishPosition.z < 50 &&
            fishPosition.y < -6 && fishPosition.x < -10)   //z범위내에 y,x 모두가 -로 벗어나는 선 전체
        {
            int num = Random.Range(1, 8);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward);
                    break;

                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.right);
                    break;

                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward + Vector3.right);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, 90, 0)); // 수직으로 올라가기
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, 45, 45));   // 사선으로 올라가기
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(45, 45, 45));     //왼쪽 위 사선으로 올라가기
                    break;
                case 7:
                    transform.rotation = Quaternion.LookRotation(new Vector3(45, 45, 0));
                    break;
            }
        }
        if (-25 < fishPosition.z && fishPosition.z < 50 &&
            fishPosition.y > 10 && fishPosition.x > 60)   //z범위내에 y,x 모두가 +로 벗어나는 선 전체
        {
            int num = Random.Range(1, 8);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back);
                    break;

                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.left);
                    break;

                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back + Vector3.left);
                    break;
                case 4:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward);
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, -90, 0));   // 수직으로 내려가기
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, -45, -45));    // 사선으로 내려가기
                    break;
                case 7:
                    this.transform.rotation = Quaternion.LookRotation(new Vector3(-45, -45, 0));
                    break;
            }
        }
        if (-25 < fishPosition.z && fishPosition.z < 50 &&
            fishPosition.y < -6 && fishPosition.x > 60)   //z범위내에 y:-, x:+  벗어나는 선 전체
        {
            int num = Random.Range(1, 8);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back);
                    break;
                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.left);
                    break;
                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back + Vector3.left);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, 90, 0)); // 수직으로 올라가기
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, 45, -45));   //사선으로 올라가기
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(-45, 45, 0));
                    break;
                case 7:
                    transform.rotation = Quaternion.LookRotation(new Vector3(-45, 45, -45));
                    break;
            }
        }
        if (-25 < fishPosition.z && fishPosition.z < 50 &&
            fishPosition.y > 10 && fishPosition.x < -10)   //z범위내에 y:+ ,x:- 로 벗어나는 선 전체
        {
            int num = Random.Range(1, 10);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward);
                    break;
                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back);
                    break;
                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back + Vector3.right);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(Vector3.forward + Vector3.right);
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(Vector3.right);
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, -90, 0));   // 수직으로 내려가기
                    break;
                case 7:
                    transform.rotation = Quaternion.LookRotation(new Vector3(45, -45, 0));    // 사선으로 내려가기
                    break;
                case 9:
                    transform.rotation = Quaternion.LookRotation(new Vector3(45, -45, 45));
                    break;
            }
        }

        //-------------------------------------------꼭짓점----------------------------------------------------

        if (fishPosition.x > 60 && fishPosition.y > 10 && fishPosition.z > 50)    // x,y,z는 +. (위, 앞, 오른쪽 x)
        {
            int num = Random.Range(1, 7);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.left);
                    break;
                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back);
                    break;
                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back + Vector3.left);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, -90, 0));   // 수직으로 내려가기
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(-45, -45, -45));    // 사선으로 내려가기
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(-45, -45, 0));
                    break;
            }
        }
        if (fishPosition.x < -10 && fishPosition.y < -6 && fishPosition.z < -25)    // x,y,z는 -.  (아래, 오른쪽,뒤 x)
        {
            int num = Random.Range(1, 7);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.right);
                    break;
                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward);
                    break;
                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward + Vector3.right);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, 90, 0));   // 수직으로 올라가기
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(45, 45, 45));    // 사선으로 올라가기
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(60, 45, 60));
                    break;
            }
        }
        if (fishPosition.x > 60 && fishPosition.y > 10 && fishPosition.z < -25)    // x:+, y:+, z:- (위, 오른쪽 뒤 x)
        {
            int num = Random.Range(1, 7);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.left);
                    break;
                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward);
                    break;
                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward + Vector3.left);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, -90, 0));   // 수직으로 내려가기
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(-45, -45, 45));    // 사선으로 올라가기
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(-60, -45, 60));
                    break;
            }
        }
        if (fishPosition.x > 60 && fishPosition.y < -6 && fishPosition.z > 50)    //  x:+, y:-, z:+
        {
            int num = Random.Range(1, 7);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.left);
                    break;
                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back);
                    break;
                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back + Vector3.left);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, 90, 0));   // 수직으로 올라가기
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(-45, 45, -45));    // 사선으로 올라가기
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(-60, 45, -60));
                    break;
            }

        }
        if (fishPosition.x < -10 && fishPosition.y > 10 && fishPosition.z > 50)    // x:-, y:+, z:+
        {
            int num = Random.Range(1, 7);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.right);
                    break;
                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back);
                    break;
                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back + Vector3.right);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, -90, 0));   // 수직으로 내려가기
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(45, -45, -45));    // 사선으로 내려가기
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(60, -45, -60));
                    break;
            }
        }
        if (fishPosition.x < -10 && fishPosition.y < -6 && fishPosition.z > 50)    //x:-, y:- z:+
        {
            int num = Random.Range(1, 7);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.left);
                    break;
                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back);
                    break;
                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.back + Vector3.left);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, 90, 0));   // 수직으로 올라가기
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(45, 45, -45));    // 사선으로 올라가기
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(60, 45, -60));
                    break;
            }
        }
        if (fishPosition.x > 60 && fishPosition.y < -6 && fishPosition.z < -25)    //x:+, y:-, z:-
        {
            int num = Random.Range(1, 7);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.right);
                    break;
                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward);
                    break;
                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward + Vector3.right);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, 90, 0));   // 수직으로 올라가기
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(-45, 45, 45));    // 사선으로 올라가기
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(-60, 45, 60));
                    break;
            }
        }
        if (fishPosition.x < -10 && fishPosition.y > 10 && fishPosition.z < -25)    //  x:-, y:+, z:-
        {
            int num = Random.Range(1, 7);
            switch (num)
            {
                case 1:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.right);
                    break;
                case 2:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward);
                    break;
                case 3:
                    this.transform.rotation = Quaternion.LookRotation(Vector3.forward + Vector3.right);
                    break;
                case 4:
                    transform.rotation = Quaternion.LookRotation(new Vector3(0, -90, 0));   // 수직으로 내려가기
                    break;
                case 5:
                    transform.rotation = Quaternion.LookRotation(new Vector3(45, -45, 45));    // 사선으로 내려가기
                    break;
                case 6:
                    transform.rotation = Quaternion.LookRotation(new Vector3(60, -45, 60));
                    break;
            }
        }
        

    }

}
