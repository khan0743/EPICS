using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1 : MonoBehaviour
{

    public GameObject[] wastes;

    public int wasteNo;

    public int score;

    public GameObject B1, B2, B3, B4;
    public Text scoreText, finalScore;


    // Start is called before the first frame update
    void Start() {
        wasteNo = 0;
        wastes[wasteNo].SetActive(true);
        score = 0;
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update() {
        if(wasteNo == 5){
            StartCoroutine(levelEnd());
        }

    }

    public void GlassBin() {
        if(wasteNo == 2 || wasteNo == 3) {
            score += 10;
        }
        nextWaste();
        
        scoreText.text = score.ToString();
        wasteNo++;
    }

    public void PaperBin() {
        if(wasteNo == 1) {
            score += 10;
        }
        nextWaste();
        
        scoreText.text = score.ToString();
        wasteNo++;
    }
    
    public void PlasticBin() {
        if(wasteNo == 0 || wasteNo == 4) {
            score += 10;
        }
        nextWaste();
        
        scoreText.text = score.ToString();
        wasteNo++;
    }

    public IEnumerator levelEnd(){
        finalScore.text = score.ToString();
        yield return new WaitForSeconds(1f);
        B1.SetActive(false);
        B2.SetActive(false);
        B3.SetActive(false);
        B4.SetActive(true);
    }

    void nextWaste(){
        wastes[wasteNo].SetActive(false);
        if(wasteNo < wastes.Length-1)
            wastes[wasteNo+1].SetActive(true);

    }
}
