using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationNativeController : MonoBehaviour
{
    public AndroidNotificationController androidNotificationController;

    private void Start()
    {
        androidNotificationController.RequestAuthorization();
        androidNotificationController.RegisterNotificationChannel();
        androidNotificationController.SendNotification("New Work Order Assigned","Tap here to view your log list and stay updated on recent activity.",1);
    }
}
