####DTH.Notifications
Compile-time, Static DLL
Classes:
* INotificationPublisher – Defines interface methods that can be implemented.
* NotificationPublisherFactory – Responsible for loading the notification dll based app.config.
* NotificationPublisher – Singleton – Provides access to the Dynamic Notification object.

Interface Methods
```c
public void PublishStatementGenerated(string statementId, string customerId, DateTime statementGenerated, DateTime statementDue, string statementLink)
```

```c
public void PublishStatementPosted(string statementId, string customerId, DateTime statementPosted, DateTime statementDue, string statementLink)
```

```c
public void PublishCycleCharge(string customerId, string cardExternalId, string authorizeNetTransactionId, float amount, string status, float currentBalance, DateTime chargeDate)
```

```c
public void PublishOneTimeCharge(string customerId, string type, string amount, string chargeDate, string chargeDescription)
```

```c
public void PublishTransaction(string customerId, string cardExternalId, string amount, string transactionType, float currentBalance)
```

####DTH.Notifications.Default
* Run-time, Dynamic DLL.
* Default implementation of the INotificationPublisher interface.

####Tresta.Notifications
* Run-time, Dynamic DLL
* Tresta-specific implementation of the INotificationPublisher interface.
  * Based on the interface method called we will create a notification object of one of the following types:
    * CycleChargeNotification
    * OneTimeChargeNotification
    * StatementGeneratedNotification
    * StatementPostedNotification
    * TransactionNotification
  * This object will be converted to JSON and published to RabbitMQ based on the settings retrieved from app.config.


Example App.config
```
<add key="Tresta.Notifications.serverAddress" value="amqp://trestadevaio10_user:trestadevaio10_password@aio10.tresta-aio.com:5672/"/>
<add key="Tresta.Notifications.exchangeType" value="topic"/>
<add key="Tresta.Notifications.exchange" value="dth"/>
<add key="Tresta.Notifications.routingKey" value="dth.notification.*.*"/>
```
####DTH.Notifications.Tester
This is a simple console application that simulates the how we envision DTH would interact with the DTH.Notification dll.
* App.Config – We updated app.config with to include the location and classname dll to load at runtime – either DTH.Notfications.Default(by default) or in our case Tresta.Notifications
```
<add key="Notification.DLL.Location" value ="C:\projects\DTH_Billing\Source\Tresta.Notifications\bin\Debug\Tresta.Notifications.dll"/>
<add key="Notification.DLL.ClassName" value ="Tresta.Notifications.NotificationPublisher"/>
```

####Example Usage:
```c
INotificationPublisher publisher = NotificationPublisher.Instance;
publisher.PublishCycleCharge("123456789", "1111111111", "TRANSID-123456789", 59.95f, "APPROVED", 0.00f, DateTime.Now);
```
