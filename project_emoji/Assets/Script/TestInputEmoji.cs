
//=======================================================
// 作者：hannibal
// 描述：测试emoji
//=======================================================
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace YX
{
	public class TestInputEmoji : MonoBehaviour
    {
        [SerializeField]
		private TMP_Text _textMeshPro;

        private void Start ()
        {
            _textMeshPro.text = "emoji_asdf45" + "\U0001F0CF" + "dddd" + "emoji_asdf45" + "\U0001F60A" + "dddd" + "emoji_asdf45" + "\U0001F60B" + "dddd";
        }
	}
}
