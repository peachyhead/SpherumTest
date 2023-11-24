// PEACHYBAND CONFIDENTIAL
// __________________
// All Rights Reserved
// [2020]-[2023].

using UnityEngine;
using UnityEngine.SceneManagement;

namespace Features.Movable.Controllers
{
    public class MovableSwitcher : MonoBehaviour
    {
        [SerializeField] private MovableObserver _movableObserver;
        [SerializeField] private Transform _spheresHolder;

        public void Start()
        {
            _movableObserver.OnLowerBound += ChangeScene;
            _movableObserver.OnBound += HideSpheres;
            _movableObserver.OnUpperBound += ShowSpheres;
        }

        private void HideSpheres()
        {
            _spheresHolder.gameObject.SetActive(false);
        }
        
        private void ShowSpheres()
        {
            _spheresHolder.gameObject.SetActive(true);
        }

        private void ChangeScene()
        {
            SceneManager.LoadScene("Level 2");
        }
    }
}