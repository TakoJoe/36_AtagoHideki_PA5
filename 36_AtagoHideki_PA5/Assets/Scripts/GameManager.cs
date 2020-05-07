using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text Coins;
    public string CoinTextPrefix;

    private int nextSceneToLoad;

    private int score;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    void Update()
    {
        if (score == 4)
        {
            SceneManager.LoadScene(nextSceneToLoad);
        }
    }

    // Update is called once per frame
    public void UpdateCoin(int _score)
    {
        score += _score;
        Coins.text = CoinTextPrefix + score;
    }

    public void restart()
    {
        SceneManager.LoadScene(1);
    }
}
