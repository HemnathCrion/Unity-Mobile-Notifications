using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using Unity.Notifications.Android;


public class AndroidNotificationController : MonoBehaviour
{
   public void RequestAuthorization()
   {
      if (!Permission.HasUserAuthorizedPermission("android.permission.POST_NOTIFICATION"))
      {
         Permission.RequestUserPermission("android.permission.POST_NOTIFICATION");
      }
   }

   public void RegisterNotificationChannel()
   {
      var channel = new AndroidNotificationChannel()
      {
         Id = "difault_channel",
         Name = "Difault Channel",
         Description = "Difault Channel",
         Importance = Importance.Default
      };
      AndroidNotificationCenter.RegisterNotificationChannel(channel);
   }

   public void SendNotification(string title, string body, int fireTimeInSecond)
   {
      var notification = new AndroidNotification();
      notification.Title = title;
      notification.Text = body;
      notification.FireTime = System.DateTime.Now.AddSeconds(fireTimeInSecond);
      AndroidNotificationCenter.SendNotification(notification, "difault_channel");

   }
}
