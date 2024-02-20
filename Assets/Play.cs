using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void LoadSceneByName()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
        SceneManager.LoadScene("Scenes/Lvl 2");
    }

    public void LoadNextInBulid()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    /*public void OpenGame(int LevelId)
    {
        string levelName = "Play Game 1" + LevelId;
        SceneManager.LoadSceneAsync(levelName);
    }
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    */
}

