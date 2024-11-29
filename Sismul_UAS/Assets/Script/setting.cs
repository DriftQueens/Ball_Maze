using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class setting : MonoBehaviour
{

    public ObserverAR[] obs;
    public GameObject penanda;

    private bool[] cekMarker;
    int countMarker = 0;


    // Start is called before the first frame update
    void Start()
    {
        cekMarker = new bool[obs.Length];
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<obs.Length; i++){
            if(obs[i].getMarker()){
                if(!cekMarker[i]){
                    countMarker++;
                    cekMarker[i] = true;

                }

            } else {
                if(cekMarker[i]){
                    countMarker--;
                    cekMarker[i] = false;

                }
            }
        }

        setPenanda();
    }

    private void setPenanda(){
        if(countMarker == 0){
            penanda.SetActive(true);
        } else{
            penanda.SetActive(false);
        }
    }

    public void setScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
