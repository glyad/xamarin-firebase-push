using Android.App;
using Android.Util;
using Firebase.Iid;
using Firebase.Messaging;

namespace FCMClient.Android.App
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.INSTANCE_ID_EVENT" })]
    public class MyFirebaseIIDService : FirebaseMessagingService
    {
        const string TAG = "MyFirebaseIIDService";

        public override void OnNewToken(string token)
        {
            var refreshedToken = FirebaseInstanceId.Instance.Token;
            refreshedToken = token;
            Log.Debug(TAG, "Refreshed token: " + refreshedToken);
            SendRegistrationToServer(refreshedToken);
        }

        void SendRegistrationToServer(string token)
        {
            // Add custom implementation, as needed.
        }
    }
}