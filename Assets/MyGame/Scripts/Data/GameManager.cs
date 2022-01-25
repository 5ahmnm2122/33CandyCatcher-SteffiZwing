using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour {

    private InputField userName;
    private TextMeshProUGUI tmpName;

    public NameData nameData;
    
    private void Start()
    {
        userName = FindObjectOfType<InputField>();
       
    }

    public void SaveName()
    {
        nameData.name = "NameData";
        nameData.yourName = userName.text;
    
    }

    public void LoadName()
    {
        if(tmpName == null)
        {
            tmpName = GameObject.Find("SavedNameTmp").GetComponent<TextMeshProUGUI>();
        }

        tmpName.text = nameData.yourName;
    }
}