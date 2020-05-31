using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject[] buttons;
    // Start is called before the first frame update
    void Start()
    {

        PlayerPrefs.DeleteAll();
       
    }

    // Update is called once per frame
    void Update()
    {
     
    }



    public void EightDay()
    {
        buttons[0].SetActive(true);
        buttons[1].SetActive(true);
        buttons[2].SetActive(false);
        buttons[3].SetActive(false);
        buttons[4].SetActive(false);
        buttons[5].SetActive(false);
        buttons[6].SetActive(false);
        buttons[7].SetActive(false);
        buttons[8].SetActive(false);
        buttons[9].SetActive(false);
        buttons[10].SetActive(false);
        buttons[11].SetActive(false);

    }
    public void NinthDay()
    {
        buttons[0].SetActive(false);
        buttons[1].SetActive(false);
        buttons[2].SetActive(true);
        buttons[3].SetActive(true);
        buttons[4].SetActive(true);
        buttons[5].SetActive(false);
        buttons[6].SetActive(false);
        buttons[7].SetActive(false);
        buttons[8].SetActive(false);
        buttons[9].SetActive(false);
        buttons[10].SetActive(false);
        buttons[11].SetActive(false);
    }

    public void TenthDay()
    {
        buttons[0].SetActive(false);
        buttons[1].SetActive(false);
        buttons[2].SetActive(false);
        buttons[3].SetActive(false);
        buttons[4].SetActive(false);
        buttons[5].SetActive(true);
        buttons[6].SetActive(true);
        buttons[7].SetActive(true);
        buttons[8].SetActive(true);
        buttons[9].SetActive(false);
        buttons[10].SetActive(false);
        buttons[11].SetActive(false);
    }

    public void EleventhDay()
    {
        buttons[0].SetActive(false);
        buttons[1].SetActive(false);
        buttons[2].SetActive(false);
        buttons[3].SetActive(false);
        buttons[4].SetActive(false);
        buttons[5].SetActive(false);
        buttons[6].SetActive(false);
        buttons[7].SetActive(false);
        buttons[8].SetActive(false);
        buttons[9].SetActive(true);
        buttons[10].SetActive(false);
        buttons[11].SetActive(false);
        buttons[12].SetActive(true);

    }

    public void TwelvethDay()
    {
        buttons[0].SetActive(false);
        buttons[1].SetActive(false);
        buttons[2].SetActive(false);
        buttons[3].SetActive(false);
        buttons[4].SetActive(false);
        buttons[5].SetActive(false);
        buttons[6].SetActive(false);
        buttons[7].SetActive(false);
        buttons[8].SetActive(false);
        buttons[9].SetActive(false);
        buttons[10].SetActive(true);
        buttons[11].SetActive(true);
    }

    //scene changingn to 8thday of HAJJ
    
    public void MovetoMakkah()
    {

        SceneManager.LoadScene("8thDay");
        PlayerPrefs.SetInt("Makkah", 1);
    }
    public void MovetoMina()
    {

        SceneManager.LoadScene("8thDay");
        PlayerPrefs.SetInt("Mina",1);

    }
    //Scene changing to 9th day of HAjj
    public void MovetoArafatAndMasjidNimra()
    {

        SceneManager.LoadScene("9thDay");
        PlayerPrefs.SetInt("ArafatANDMasjidNimra", 1);
    }

  

    public void MovetoMuzdalifa()
    {
        SceneManager.LoadScene("9thDay");
        PlayerPrefs.SetInt("Muzdalifa",1);
    }


    //Scnene Changing to 10th day of Hajj
    public void MovetoMina2()
    {
        SceneManager.LoadScene("10thDay");
        PlayerPrefs.SetInt("Mina2",1);

    }

    public void MovetoJamaratUlUqbah()
    {
        SceneManager.LoadScene("10thDay");
        PlayerPrefs.SetInt("JamaratUlUqbah",1);

    }

    public void MovetoQurbani()
    {
        SceneManager.LoadScene("10thDay");
        PlayerPrefs.SetInt("Qurbani", 1);
        

    }

    public void MovetoHalq()
    {
        SceneManager.LoadScene("10thDay");
        PlayerPrefs.SetInt("Halq", 1);
    }


    //Scene changing to 11th day of hajj
    public void MovetoJamarat()
    {
        SceneManager.LoadScene("11thDay");
        PlayerPrefs.SetInt("Jamarat1", 1);
    }
    public void MovetoTawaafeZiyaraah()
    {
        SceneManager.LoadScene("11thDay");
        PlayerPrefs.SetInt("Tawaaf", 1);
    }

    // Scene changes to 12th Day of Hajj
    public void MovetoJamarat2()
    {
        SceneManager.LoadScene("12thDay");
        PlayerPrefs.SetInt("Jamarat2", 1);
    }

    public void MovetoTawafWida()
    {
        SceneManager.LoadScene("12thDay");
        PlayerPrefs.SetInt("TawafWida", 1);
        
    }

    public void MenuFalse()
    {
        for (int i = 0; i <= buttons.Length - 1; i++)
        {
            buttons[i].SetActive(false);
        }
    }
}


