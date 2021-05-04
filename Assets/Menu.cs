using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Menu : MonoBehaviour
{
    public TMPro.TMP_Text txt_rm_ads;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("ads"))
        {
            GameObject.Find("txt_rm_ads").GetComponent<TMPro.TextMeshProUGUI>().text = "Thank You";
        }   
    }

    // Update is called once per frame
    void Update()
    {
    }
}
