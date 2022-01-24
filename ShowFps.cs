using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowFps : MonoBehaviour
{
    private float pollingTime = 1f;
	private float time;
	private int frameCount;
    public Text m_Text;

    void Update() {
		// Update time.
		time += Time.deltaTime;

		// Count this frame.
		frameCount++;

		if (time >= pollingTime) {
			// Update frame rate.
			int frameRate = Mathf.RoundToInt((float)frameCount / time);
            m_Text.text = "Game FPS :";
			m_Text.text = frameRate.ToString() + " FPS";

			// Reset time and frame count.
			time -= pollingTime;
			frameCount = 0;
		}
	}
}


	
	

 
	