using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restartlvl : MonoBehaviour
{
    [SerializeField]
    string ballTag;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag==ballTag)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
