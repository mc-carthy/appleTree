using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu ("Vistage/HighScore")]
public class HighScore : MonoBehaviour {

	static public int highScore = 10;

	static public Text highScoreText;

	private void Awake ()
	{
		highScoreText = GetComponent<Text> ();

		if (PlayerPrefs.HasKey ("applePickerHighScore")) 
		{
			highScore = PlayerPrefs.GetInt("applePickerHighScore");
		}

		PlayerPrefs.SetInt ("applePickerHighScore", highScore);
	}

	private void Start ()
	{
		UpdateText ();
	}

	public static void UpdateText ()
	{
		highScoreText.text = highScore.ToString ();

		if (highScore > PlayerPrefs.GetInt ("applePickerHighScore"))
		{
			PlayerPrefs.SetInt ("applePickerHighScore", highScore);
		}
	}
}
