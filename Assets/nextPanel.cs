using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextPanel : MonoBehaviour {
    
    public GameObject MainCamera;

    public void nextPage()
    {


        if (this.tag == "next1")
        {
            MainCamera.transform.rotation = Quaternion.LookRotation(Vector3.right);
        }
        else if (this.tag == "next2")
        {
            MainCamera.transform.rotation = Quaternion.LookRotation(Vector3.back);
        }
        else if (this.tag == "next3")
        {
            MainCamera.transform.rotation = Quaternion.LookRotation(Vector3.left);
        }

        else if (this.tag == "previous2")
        {
            MainCamera.transform.rotation = Quaternion.LookRotation(Vector3.forward);
        }
        else if (this.tag == "previous3")
        {
            MainCamera.transform.rotation = Quaternion.LookRotation(Vector3.right);
        }
        else if (this.tag == "previous4")
        {
            MainCamera.transform.rotation = Quaternion.LookRotation(Vector3.back);
        }
            
    }


}
