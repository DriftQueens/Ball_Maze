using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class ButtonDownload : MonoBehaviour
{   
    private string googleDriveLink = "https://drive.google.com/file/d/1kJPAc6D1y3iwzHxkXAdYGbtrQuqvXI2l/view?usp=drive_link";

    public void OpenDriveLink()
    {
        // Membuka URL di browser default perangkat
        Application.OpenURL(googleDriveLink);
    }
}