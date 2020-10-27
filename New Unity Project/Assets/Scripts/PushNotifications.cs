using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class PushNotifications : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var c = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.High,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(c);
        TestNotification("start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TestNotification(string text)
    {
        var notification = new AndroidNotification();
        notification.Title = "SomeTitle";
        notification.Text = text;
        notification.FireTime = System.DateTime.Now.AddSeconds(3);
        AndroidNotificationCenter.SendNotification(notification, "channel_id");
    }
}
