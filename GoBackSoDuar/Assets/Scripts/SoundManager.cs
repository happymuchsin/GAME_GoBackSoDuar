using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {

	[SerializeField]
	private AudioSource musicSource;

	[SerializeField]
	private AudioSource sfxSource;

	[SerializeField]
	private Slider musicSlider;

	[SerializeField]
	private Slider sfxSlider;

	Dictionary<string, AudioClip> audioClips = new Dictionary<string, AudioClip>();

	public static SoundManager instance;

	public void Awake() {
		if (instance != null) {
			Destroy (gameObject);
		}
		else {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		AudioClip[] clips = Resources.LoadAll<AudioClip>("Audio") as AudioClip[];
		
		foreach (AudioClip clip in clips) {
			audioClips.Add(clip.name, clip);
		}

		LoadVolume();

		musicSlider.onValueChanged.AddListener(delegate { UpdateVolume(); });
		sfxSlider.onValueChanged.AddListener(delegate { UpdateVolume(); });
	}

	public void PlaySFX(string name) {
		sfxSource.PlayOneShot(audioClips[name]);
	}

	public void UpdateVolume() {
		musicSource.volume = musicSlider.value;

		sfxSource.volume = sfxSlider.value;

		PlayerPrefs.SetFloat("Music", musicSlider.value);
		PlayerPrefs.SetFloat("SFX", sfxSlider.value);
	}

	public void LoadVolume() {
		musicSource.volume = PlayerPrefs.GetFloat("Music", 0.5f);
		sfxSource.volume = PlayerPrefs.GetFloat("SFX", 0.5f);

		musicSlider.value = musicSource.volume;
		sfxSlider.value = sfxSource.volume;
	}
}
