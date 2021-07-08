using UnityEngine ;
using GG.Infrastructure.Utils.Swipe ;

public class Demo : MonoBehaviour {
   [SerializeField] private SwipeListener swipeListener ;
   [SerializeField] private Transform playerTransform ;
   [SerializeField] private float playerSpeed ;

   private Vector2 playerDirection = Vector2.zero ;

   private void OnEnable () {
      swipeListener.OnSwipe.AddListener (OnSwipe) ;
   }

   private void OnSwipe (string swipe) {
      switch (swipe) {
         case "Left":
            playerDirection = Vector2.left ;
            break ;
         case "Right":
            playerDirection = Vector2.right ;
            break ;
         case "Up":
            playerDirection = Vector2.up ;
            break ;
         case "Down":
            playerDirection = Vector2.down ;
            break ;


         case "UpLeft":
            playerDirection = new Vector2 (-1f, 1f) ;
            break ;
         case "UpRight":
            playerDirection = new Vector2 (1f, 1f) ;
            break ;
         case "DownLeft":
            playerDirection = new Vector2 (-1f, -1f) ;
            break ;
         case "DownRight":
            playerDirection = new Vector2 (1f, -1f) ;
            break ;
      }
   }

   private void Update () {
      playerTransform.position += (Vector3)playerDirection * playerSpeed * Time.deltaTime ;
   }

   private void OnDisable () {
      swipeListener.OnSwipe.RemoveListener (OnSwipe) ;
   }
}
