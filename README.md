# xamarin-firebase-push

## FCMClient.Android.App

Setup your Firebase account with new mobile application.

IMPORTANT! Before first run set the breakpoint on ```MyFirebaseMessagingService.OnNewToken()``` method and run the app in debug mode. 

Copy the token and store it to further using in Firebase Cloud Messaging. 

In Firebase project console in section 'Cloud Messaging' press 'New Notification' button. 

Set 'Notification title' and 'Notification text'. 

Press 'Send test message'. 

In opened dialog put the token and press 'Test' button.
