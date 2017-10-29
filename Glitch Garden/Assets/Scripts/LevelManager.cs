using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    private float timer;
    private float timerLimit = 5f;

    void Start()
    {
        Invoke("LoadNextLevel", timerLimit);
        timer = timerLimit;
        InvokeRepeating("CheckTimer", 1f, 1f);
    }

    void CheckTimer()
    {
        timer -= 1f;
        Debug.Log("Load start screen in: " + timer + " seconds");
        if (timer == 0)
        {
            CancelInvoke("CheckTimer");
            Invoke("LoadNextLevel", timerLimit);
            Application.LoadLevel("Start Menu");
        }
    }

    public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

}
