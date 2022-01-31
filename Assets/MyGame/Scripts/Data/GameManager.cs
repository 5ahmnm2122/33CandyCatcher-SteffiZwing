using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour {

    private InputField userName;
    private TextMeshProUGUI tmpName;
    public Text nameTxt;
    public Text pointsTxt;

    public NameData nameData;
    public MyScore scoreData;
    
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

        pointsTxt.text = scoreData.score.ToString();
        tmpName.text = nameData.yourName;
        nameTxt.text = nameData.yourName;
    }
}