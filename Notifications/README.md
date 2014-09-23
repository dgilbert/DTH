####DTH.Notifications
Compile-time, Static DLL
Classes:
* INotificationPublisher – Defines interface methods that can be implemented.
* NotificationPublisherFactory – Responsible for creating the dynamic Notification object.
* NotificationPublisher – Singleton – Provides access to the Dynamic Notification object.

####DTH.Notifications.Default
* Run-time, Dynamic DLL.  Contains the default implementation of the INotificationPublisher interface.  
* Default implementation of the INotificationPublisher interface.

####Tresta.Notifications
* Run-time, Dynamic DLL
* This is PATLive(Tresta) implementation of the INotificationPublisher interface.  

####DTH.Notifications.Tester
This is a simple console application that simulates the how we envision DTH would interact with the DTH.Notification dll.
* App.Config – We updated app.config with to include the location and classname dll to load at runtime – either DTH.Notfications.Default(by default) or in our case Tresta.Notifications
```
<add key="Notification.DLL.Location" value ="C:\projects\DTH_Billing\Source\Tresta.Notifications\bin\Debug\Tresta.Notifications.dll"/>
<add key="Notification.DLL.ClassName" value ="Tresta.Notifications.NotificationPublisher"/>
```
