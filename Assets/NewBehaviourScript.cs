using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI watertext,wheattext,breadtext;
    int water = 0;
    int wheat = 0;
    int bread = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        watertext.text=water.ToString();
        wheattext.text=wheat.ToString();
        breadtext.text=bread.ToString();
        water= PlayerPrefs.GetInt("water",water);
        wheat= PlayerPrefs.GetInt("wheat",wheat);
        bread= PlayerPrefs.GetInt("bread",bread);
        waterclick();
        breadclick();
        wheatclick();
    }

    public void waterclick()
    {
        water++;
        watertext.text = water.ToString();
        data();
    }
    public void wheatclick()
    {
        if (water > 0)
        {
            wheat++;
            watertext.text = water.ToString();
            water--;
            wheattext.text = wheat.ToString();
            data();
        }
    }
    public void breadclick()
    {
        if (water >= 5 && wheat>=7)
        {
            bread++;
            water -= 5;
            wheat -= 7;
            breadtext.text = bread.ToString();
            wheattext.text=wheat.ToString();
            watertext.text=water.ToString() ;
            data();
            
        }
        
    }
    public void data()
    {
        PlayerPrefs.SetInt("water", water);
        PlayerPrefs.SetInt("wheat", wheat);
        PlayerPrefs.SetInt("bread", bread);
    }
    
}
