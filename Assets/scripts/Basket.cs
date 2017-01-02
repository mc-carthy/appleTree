using UnityEngine;

[AddComponentMenu ("Vistage/Basket")]
public class Basket : MonoBehaviour {

	private void Update ()
	{
		Move ();
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

	private void OnCollisionEnter (Collision other)
	{
		GameObject collided = other.gameObject;

		if (collided.tag == "apple")
		{
			Destroy(collided.gameObject);
		}
	}
}
