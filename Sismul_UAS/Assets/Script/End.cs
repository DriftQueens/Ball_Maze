using System.Collections;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject victoryPanel;
    public GameObject optionsPanel;
    public float displayTime = 5f;
    private AudioSource audioSource;

    private void Start()
    {
        // Mengambil AudioSource dari game object ini
        audioSource = GetComponent<AudioSource>();

        // Validasi untuk memastikan objek yang diperlukan telah diatur
        if (victoryPanel == null)
        {
            Debug.LogWarning("Victory Panel is not assigned in the inspector.");
        }

        if (optionsPanel == null)
        {
            Debug.LogWarning("Options Panel is not assigned in the inspector.");
        }

        if (audioSource == null)
        {
            Debug.LogWarning("No AudioSource component found on this GameObject.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Tampilkan Victory Panel ketika ada objek yang memicu
        StartCoroutine(ShowVictoryPanel());
    }

    private IEnumerator ShowVictoryPanel()
    {
        // Mainkan suara jika AudioSource tersedia
        if (audioSource != null)
        {
            audioSource.Play();
        }

        // Hentikan waktu (membuat semua elemen game berhenti bergerak)
        Time.timeScale = 0;

        // Tampilkan panel kemenangan jika tersedia
        if (victoryPanel != null)
        {
            victoryPanel.SetActive(true);
        }

        // Tunggu selama waktu yang ditentukan dalam waktu dunia nyata
        yield return new WaitForSecondsRealtime(displayTime);

        // Sembunyikan panel kemenangan
        if (victoryPanel != null)
        {
            victoryPanel.SetActive(false);
        }

        // Tampilkan panel opsi jika tersedia
        if (optionsPanel != null)
        {
            optionsPanel.SetActive(true);
        }

        // Hentikan suara jika masih aktif
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        // Tetap menghentikan waktu hingga pemain memilih opsi
        while (optionsPanel.activeSelf)
        {
            yield return null; // Tunggu hingga frame berikutnya
        }

        // Aktifkan kembali waktu setelah opsi dipilih
        Time.timeScale = 1;
    }
}
