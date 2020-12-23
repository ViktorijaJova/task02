using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace Assets
{
  public  class CubeController:MonoBehaviour
    {
        [SerializeField] GameObject cube1;
        [SerializeField] Button button;

        void Start()
        {
            button.gameObject.SetActive(false);
            button.onClick.AddListener(() => Restart());
        }


           void OnCollisionEnter(Collision col)
            {
            if (col.gameObject.name == "CubeTwo")
            {
                col.gameObject.GetComponent<Renderer>().material.color = Color.red;
                cube1.GetComponent<Renderer>().material.color = Color.yellow;
                button.gameObject.SetActive(true);
            }
            }

             void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Vector3 position = this.transform.position;
                position.z++;
                this.transform.position = position;
            }
        }

   
        void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
