using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatMessage : MonoBehaviour
{
    [SerializeField] Text text;

    public void ShowMessage(string message)
    {
        text.text = message;
    }
}
