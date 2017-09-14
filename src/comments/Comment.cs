using UnityEngine;

namespace BeatThat
{

	/// <summary>
	/// Add a comment to a GameObject
	/// </summary>
	public class Comment : MonoBehaviour 
	{
		[Multiline(10)]
		public string text;
	}
}
