using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
	private static SoundManager instance;
	public AudioClip explosionAudio;

	public AudioClip startVoiceAudio;
	public AudioClip fireVoice1Audio;
	public AudioClip fireVoice2Audio;
	public AudioClip endVoiceAudio;
	private AudioSource voiceAudioSource;

	public static SoundManager Instance {
		get {
			if (instance == null) {
				instance = (SoundManager)FindObjectOfType(typeof(SoundManager));
				if (instance == null) {
					Debug.LogError("SoundManager Instance Error");
				}
			}
			return instance;
		}
	}

	void Start() {
		this.voiceAudioSource = gameObject.AddComponent<AudioSource>();
	}

	public void PlayExplosionAudio() {
		audio.PlayOneShot(explosionAudio);
	}

	public void PlayStartVoice() {
		voiceAudioSource.PlayOneShot(startVoiceAudio);
	}

	public void PlayFireVoice1() {
		voiceAudioSource.PlayOneShot(fireVoice1Audio);
	}

	public void PlayFireVoice2() {
		voiceAudioSource.PlayOneShot(fireVoice2Audio);
	}

	public void PlayEndVoice() {
		voiceAudioSource.PlayOneShot(endVoiceAudio);
	}
}
