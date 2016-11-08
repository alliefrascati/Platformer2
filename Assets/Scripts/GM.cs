using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GM : MonoBehaviour {

    public int coins = 0;
    public int lives = 3;
    public int total = 4;

    public GameObject outSign;
    public GameObject winSign;

    public Text coinsText;
    public Text livesText;


	void Start () {
        coinsText.text = coins.ToString();
        livesText.text = lives.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CoinWasPickedUp(int worth)
    {
        coins+= worth;
        coinsText.text = coins.ToString();
        if(coins==total)
        {
            winSign.SetActive(true);
        }
    }

    public void LifeWasLost()
    {
        lives --;
        livesText.text = lives.ToString();

        if(lives == 0)
        {
            outSign.SetActive(true);
        }
    }
}
