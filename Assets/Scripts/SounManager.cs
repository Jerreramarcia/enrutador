using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SounManager : MonoBehaviour
{
    
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;  
    [Header("Volume Slider")]
    [SerializeField] private Text volumeTextValue;
    [SerializeField] private Slider volumeSlider;
    public bool muted = true; 

    void Start(){

        if(!PlayerPrefs.HasKey("muted")){

            PlayerPrefs.SetInt("muted",0);

            load();

        }else{

            load();

        }

        changeText();
        AudioListener.pause = muted;

    }

    private void changeText(){

    if(muted == true){

        soundOffIcon.enabled = true;
        soundOnIcon.enabled = false;

    }else{

        soundOnIcon.enabled = true;
        soundOffIcon.enabled = false;


    }   

    save();
    
        
    }

    public void buttonPress(){

        if(muted == true){

            muted = false;
            AudioListener.pause = false;

        }else{

            muted = true;
            AudioListener.pause = true;
        }

        save();
        changeText();

    }

    private void load(){

        muted = PlayerPrefs.GetInt("muted")==0;

    }

    private void save(){

        PlayerPrefs.SetInt("muted", muted ? 1: 0);

    }

    public void setVolume(float volume){

            AudioListener.volume = volume;
            volumeTextValue.text = volume.ToString("0.0");
            PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);

    }    

}
