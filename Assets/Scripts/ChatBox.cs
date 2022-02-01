using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatBox : MonoBehaviour
{
    [SerializeField] GameObject newMessagePrefab;
    [SerializeField] Transform messageParentPanel;

    string message = "";

    public void SetMessage(string message)
    {
        this.message = message;
    }
    public void ShowMessage()
    {
        if (message != "")
        {
            GameObject clone = Instantiate(newMessagePrefab);
            clone.transform.SetParent(messageParentPanel);
            clone.transform.SetSiblingIndex(messageParentPanel.childCount);
            clone.transform.localScale = Vector3.one;
            clone.GetComponent<ChatMessage>().ShowMessage(message);
        }
    }
}
