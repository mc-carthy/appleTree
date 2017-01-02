using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu ("Vistage/Basket")]
public class Basket : MonoBehaviour {

	private Text scoreText;
	private int score;

	private void Start ()
	{
		scoreText = GameObject.Find("scoreText").GetComponent<Text> ();
		score = 0;
		UpdateScoreText ();
	}

	private void Update ()
	{
		Move ();
	}

	private void OnCollisionEnter (Collision other)
	{
		GameObject collided = other.gameObject;

		if (collided.tag == "apple")
		{
			score++;
			UpdateScoreText ();

			if (score > HighScore.highScore)
			{
				HighScore.highScore = score;
				HighScore.UpdateText ();
			}

			Destroy (collided.gameObject);
		}
	}

	private void Move ()
	{
		Vector3 mousePos2D = Input.mousePosition;
		mousePos2D.z = -Camera.main.transform.position.z;

		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint (mousePos2D);

		Vector3 pos = transform.position;
		pos.x = mousePos3D.x;
		transform.position = pos;
	}

	private void UpdateScoreText ()
	{
		scoreText.text = score.ToString ();
	}
}
