using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collect : MonoBehaviour
{


    public GameObject clueImg;
    public AudioSource Correct;

    [SerializeField] private Animator MyAnimationController;


    public void onSubmit()
    {


        Destroy(clueImg);

        Debug.Log("You did it!");
        //  MyAnimationController.SetBool("open", true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Correct.Play();




    }



}
