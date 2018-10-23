using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject _uiLost;
    public GameObject _uiWon;

    public int _enemyCount;


	#region GameManagerSingleton Declaration
	public static GameManager Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    void Start () {
		
	}
	
	void Update () {

        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().hp <= 0f)
        {
            _uiLost.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }

        if (_enemyCount <= 0)
        {
            _uiWon.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }

        if (Time.timeScale <= 0f && Input.GetKeyDown(KeyCode.F))
        {
            Time.timeScale = 1f;
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}

