using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    Scene m_Lose;
    string LoseScreen;
    // Start is called before the first frame update
    void Start()
    {
        m_Lose = SceneManager.GetActiveScene();
        LoseScreen = m_Lose.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Me"))
        {
            SceneManager.LoadScene(3);
        }
    }
}
