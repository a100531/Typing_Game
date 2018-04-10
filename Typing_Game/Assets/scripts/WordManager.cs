using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {

	 public List<Word> words;
	 public WordSpawner wordSpawner;
	 private bool hasActiveWord;
	 //public bool begin;
	 private Word activeWord;

	 #region methods
		 private void Start() {
			 //begin = false;
		 }
		 public void AddWord()
		 {
			 //if (begin)
			 //{
				Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
			 	//Debug.Log(word.word);

			 	words.Add(word);
			// }
			 
		 }

		 public void TypeLetter(char letter)
		 {
			if(hasActiveWord)
			{
				if (activeWord.GetNextLetter() == letter)
				{
					activeWord.TypeLetter();
				}
			}
			else
			{
				foreach(Word word in words)
				{
					if (word.GetNextLetter() == letter)
					{
						activeWord = word;
						hasActiveWord = true;
						word.TypeLetter();
						break;
					}
				}
			}
			if (hasActiveWord && activeWord.WordTyped())
			{
				hasActiveWord = false;
				words.Remove(activeWord);
			}
		 }
	 #endregion

}
