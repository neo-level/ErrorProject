using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CongratScript : MonoBehaviour
{
    public TextMesh text;
    public ParticleSystem sparksParticles;

    [SerializeField] private List<string> textToDisplay;

    private float _rotatingSpeed;
    private float _timeToNextText;

    private int _currentText;

    // Start is called before the first frame update
    void Start()
    {
        _timeToNextText = 0.0f;
        _currentText = 0;

        _rotatingSpeed = 1.0f;

        textToDisplay.Add("Congratulation");
        textToDisplay.Add("All Errors Fixed");

        text.text = textToDisplay[0];


        sparksParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        _timeToNextText += Time.deltaTime;

        if (_timeToNextText > 1.5f)
        {
            _timeToNextText = 0.0f;

            _currentText++;
            if (_currentText >= textToDisplay.Count)
            {
                _currentText = 0;
            }

            text.text = textToDisplay[_currentText];
        }

        transform.Rotate(0, 0, -_rotatingSpeed, Space.Self);

    }
}