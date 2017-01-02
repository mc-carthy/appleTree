using UnityEngine;

[AddComponentMenu ("Vistage/AppleTree")]
public class AppleTree : MonoBehaviour {

	public GameObject applePrefab;

	public float moveSpeed;
	public float leftRightEdge;
	public float chanceToChangeDir;
	public float timeBetweenAppleDrops;

	private Vector3 pos;

	private void Start ()
	{
		// Begin apple dropping
	}

	private void Update ()
	{
		Move();
		ChangeDirection();
	}

	private void Move ()
	{
		pos = transform.position;
		pos.x += moveSpeed * Time.deltaTime;
		transform.position = pos;
	}

	private void ChangeDirection ()
	{
		if (pos.x < -leftRightEdge)
		{
			moveSpeed = Mathf.Abs(moveSpeed);
		}
		if (pos.x > leftRightEdge)
		{
			moveSpeed = -Mathf.Abs(moveSpeed);
		}
	}
}
