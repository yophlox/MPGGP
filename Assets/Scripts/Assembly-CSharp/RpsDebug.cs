using UnityEngine;
using UnityEngine.UI;

public class RpsDebug : MonoBehaviour
{
	[SerializeField]
	private Button ConnectionDebugButton;

	public bool ShowConnectionDebug;

	public void ToggleConnectionDebug()
	{
		ShowConnectionDebug = !ShowConnectionDebug;
	}

	public void Update()
	{
		if (ShowConnectionDebug)
		{
			ConnectionDebugButton.GetComponentInChildren<Text>().text = PhotonNetwork.connectionStateDetailed.ToString();
		}
		else
		{
			ConnectionDebugButton.GetComponentInChildren<Text>().text = "";
		}
	}
}
