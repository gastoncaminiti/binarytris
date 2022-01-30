using UnityEngine;
using UnityEngine.SceneManagement;
public class LandingManager : MonoBehaviour
{
	public void startPlay()
	{
        
		SceneManager.LoadScene("Game");
        GetComponent<AudioSource>().Play();
	}
}
