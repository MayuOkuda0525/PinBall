//ScoreTextにアタッチ
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
	//Scoreを表示するテキスト
	private GameObject scoreText;

	//Score計算用変数
	private int score = 0;

	// Use this for initialization
	void Start()
	{
		this.scoreText = GameObject.Find("ScoreText");
	}


	void OnCollisionEnter(Collision other)
	{
		this.scoreText.GetComponent<Text>().text = "Score:" + score;

		if(other.gameObject.tag == "SmallCloudTag" || other.gameObject.tag == "SmallStarTag")
		{
			score += 10;
			this.scoreText.GetComponent<Text>().text = "Score:" + score;
		} 
		else if(other.gameObject.tag == "LargeCloudTag" || other.gameObject.tag == "LargeStarTag")
		{
			score += 20;
			this.scoreText.GetComponent<Text>().text = "Score:" + score;
		}
	}

	// Update is called once per frame
	void Update()
	{
		//this.scoreText.GetComponent<Text>().text = "Score:" + score;
	}
}
