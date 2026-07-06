using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance { get; private set; }

    public AudioClip dayMusic;
    public AudioClip nightMusic;

    private AudioSource source;

    void Awake()
    {
        if (Instance != null) { Destroy(gameObject); return; }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        source = GetComponent<AudioSource>();
    }

    void Start()
    {
        PlayDay();
    }

    public void PlayDay()
    {
        if (source.clip == dayMusic && source.isPlaying) return;
        source.clip = dayMusic;
        source.Play();
    }

    public void PlayNight()
    {
        if (source.clip == nightMusic && source.isPlaying) return;
        source.clip = nightMusic;
        source.Play();
    }
}
