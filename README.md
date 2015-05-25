# MandrillSample
This sample shows you how to setup Mandrill API with C#. Mandrill its a great tool for sending emails and it counts with a nice API easy to use.

##Basic Setup
In order to use Mandrill you need to get an api key. For this, go to your account dashboard, settings, and click the "+ New Api Key" button. That's the only thing you need for now.

##Creating Templates
With Mandrill you can create html templates using your dashboard. So you don't have to worry about creating html files in your code :). Also, it's really easy to specify parameters to the templates for showing some specific information. If you want to read more about follow this link [https://mandrill.zendesk.com/hc/en-us/sections/200775387-Templates-and-Dynamic-Content] 

##Let's Code
Create a mandrill cliente like this:

```
var mandrill = new MandrillApi(apiKey);
```

now you can call the SendMessageTemplate in order to send an email using a template. Be sure to add this.

```
new List<TemplateContent> {
	 new TemplateContent
	 {  Name = "TITLE",
	    Content = "Content1"
	 },
	 new TemplateContent 
	 { 
	   Name = "CONTENT",
	   Content = "Content2"
	 }
}
```
Replace each tag from you templates with the values you want to show.

HAPPY CODING!! :)



