using UnityEngine;
using System.Collections;

public class CursorLock : MonoBehaviour
{
	void Update ()
	{
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
}