using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loginPage : MonoBehaviour
{
    // Start is
    // called before the first frame update

    public float time = 1.0f;
    void Start()
    {
        StartCoroutine(login());

    }

    // Update is called once per frame
    
    IEnumerator login()
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(2);
    }
}

