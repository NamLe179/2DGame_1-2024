using Managers;
using UnityEngine;

namespace Controllers
{
    public class End : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            GameManager.Instance.EndGame();
            
        }
    }

}
