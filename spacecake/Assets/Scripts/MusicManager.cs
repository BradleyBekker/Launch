using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

	public GameObject theme1;
	private AudioSource source1;
	public float source1Volume;
	public bool source1Finished = false;

	public GameObject theme2;
	private AudioSource source2;
	public float source2Volume;
	public bool source2Finished = false;

	public GameObject theme3;
	private AudioSource source3;
	public float source3Volume;
	public bool source3Finished = false;


	private bool transDefaultRunning;
	private bool trans1Running;
	private bool trans2Running;

	public float volumeAdjustmentPerFrame;

	// Use this for initialization
	void Start () {
		source1 = theme1.GetComponent<AudioSource>();
		source2 = theme2.GetComponent<AudioSource>();
		source3 = theme3.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(transDefaultRunning) {
			transitionDefault();
		}
		if(trans1Running) {
			transition1();
		}
		if(trans2Running) {
			transition2();
		}
		//between 0-1
		//source1.volume = ;
	}

	// change themesong back to default
	public void transitionDefault()
	{
		if(source1.volume < 1 && !source1Finished) {
			if(source1.volume + volumeAdjustmentPerFrame > 1) {
				source1.volume = 1;
				source1Finished = true;
			}
			else source1.volume += volumeAdjustmentPerFrame;
		}

		if(source2.volume > 0 && !source2Finished) {
			if(source2.volume - volumeAdjustmentPerFrame < 0) {
				source2Volume = 0;
				source2Finished = true;
			}
			else source2.volume -= volumeAdjustmentPerFrame;
		}

		if(source3.volume > 0 && !source3Finished) {
			if(source3.volume - volumeAdjustmentPerFrame < 0) {
				source3Volume = 0;
				source3Finished = true;
			}
			else source3.volume -= volumeAdjustmentPerFrame;
		}

		if(source1Finished && source2Finished && source3Finished) {
			transDefaultRunning = false;
			source1Finished = false;
			source2Finished = false;
			source3Finished = false;
		}
	}

	// change themesong to 2nd fase
	public void transition1()
	{
		if(source1.volume > 0 && !source1Finished) {
			if(source1.volume - volumeAdjustmentPerFrame < 0) {
				source1.volume = 0;
				source1Finished = true;
			}
			else source1.volume -= volumeAdjustmentPerFrame;
		}

		if(source2.volume < 1 && !source2Finished) {
			if(source2.volume + volumeAdjustmentPerFrame > 1) {
				source2Volume = 1;
				source2Finished = true;
			}
			else source2.volume += volumeAdjustmentPerFrame;
		}

		if(source1Finished && source2Finished) {
			trans1Running = false;
			source1Finished = false;
			source2Finished = false;
		}
	}

	// change themesong to final fase
	public void transition2()
	{
		if(source2.volume > 0 && !source2Finished) {
			if(source2.volume - volumeAdjustmentPerFrame < 0) {
				source2Volume = 0;
				source2Finished = true;
			}
			else source2.volume -= volumeAdjustmentPerFrame;
		}

		if(source3.volume < 1 && !source3Finished) {
			if(source3.volume + volumeAdjustmentPerFrame > 1) {
				source3Volume = 1;
				source3Finished = true;
			}
			else source3.volume += volumeAdjustmentPerFrame;
		}

		if(source2Finished && source3Finished) {
			transDefaultRunning = false;
			source2Finished = false;
			source3Finished = false;
		}
	}

}
