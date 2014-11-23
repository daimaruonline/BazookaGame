using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	public GameObject bear;

	int score = 0;
	float elapsedTime;
	const float BASE_WIDTH = 511;
	public GUIStyle style = new GUIStyle();
	public GUIStyle endMsgStyle = new GUIStyle();
	Rect scoreRect = new Rect(400, 10, 70, 30);
	Rect timerRect = new Rect(350, 50, 120, 30);
	Rect endMsgRect = new Rect(50, 10, 200, 35);
	Rect rankMsgRect = new Rect(50, 85, 250, 30);
	Rect replayBtnRect = new Rect(50, 150, 120, 40);

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 9; i++) {
			Instantiate(bear);
		}

		scoreRect = MakeRect(scoreRect);
		timerRect = MakeRect(timerRect);
		endMsgRect = MakeRect(endMsgRect);
		rankMsgRect = MakeRect(rankMsgRect);
		replayBtnRect = MakeRect(replayBtnRect);
	}
	
	// Update is called once per frame
	void Update () {
		if (!FinishedGame()) {
			elapsedTime += Time.deltaTime;
		}
	}

	public void AddScore() {
		score++;
	}

	bool FinishedGame() {
		return GameObject.FindWithTag("Teddy") == null;
	}

	float GetValueByScreenSize(float x) {
		float ratio = Screen.width / BASE_WIDTH;
		return x * ratio;
	}

	Rect MakeRect(Rect defaultRect) {
		float left = GetValueByScreenSize(defaultRect.xMin);
		float top = GetValueByScreenSize(defaultRect.y);
		float width = GetValueByScreenSize(defaultRect.width);
		float height = GetValueByScreenSize(defaultRect.height);
		Rect newRect = new Rect(left, top, width, height);
		return newRect;
	}

	void OnGUI() {
		GUI.Label(scoreRect, "Score " + score, style);
		GUI.Label(timerRect, "Time " + elapsedTime, style);
		if (FinishedGame()) {
			GUI.Label(endMsgRect, "Game Cear!!", endMsgStyle);
			GUI.Label(rankMsgRect, "Your Time is " + elapsedTime + ".", style);
			if (GUI.Button(replayBtnRect, "Replay?")) {
				Application.LoadLevel("Teddy Bear Bazooka");
			}
		}
	}

}
