using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
{
	public float speed;
	public bool toRight;
	public GameObject baseI;
	public GameObject baseD;

	public GameObject prefabE;
	public GameObject prefabC;

	int yOffset;
    // Start is called before the first frame update
    void Start()
    {
		toRight = true;
		yOffset = 1;
    }

    // Update is called once per frame
    void Update()
    {
		if (toRight == true)
		{
			transform.position += new Vector3(speed, 0, 0);
		}
		else
		{
			transform.position -= new Vector3(speed, 0, 0);

		}
		if (transform.position.x > baseD.transform.position.x -1 )
		{
			toRight = false;
			GameObject clon;
			clon = Instantiate(prefabC);
			clon.transform.position = baseD.transform.position + new Vector3(0, yOffset + yOffset);
			yOffset++;
			
		}
		if (transform.position.x < baseI.transform.position.x + 1)
		{
			toRight = true;
			GameObject clon;
			clon = Instantiate(prefabE);
			clon.transform.position = baseI.transform.position + new Vector3(0, yOffset + yOffset);
			yOffset++;
		}

	}
}
