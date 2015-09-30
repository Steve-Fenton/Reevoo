# Reevoo
A .NET wrapper for the [Reevoo V4 API](http://reevoo.github.io/docs/reevooapi/reevooapi-getting-started/)

## Instantiating the API

You can instantiate the API by passing your key and secret (and optionally, the Base URI for the service):

    var reevooApi = new ReevooApi(key, secret);

Alternatively, place the following in your configuration file:

    <appSettings>
        <add key="Key" value="YOUR_KEY" />
        <add key="Secret" value="YOUR-SECRET" />
        <add key="BaseAddress" value="https://api.reevoocloud.com/"/>
    </appSettings>

This allows the argument free version below:

    var reevooApi = new ReevooApi();

## Using methods on the API

The Revoo API class provides access to multiple APIs contained within the service.

The example below calls the Conversation API and asks for a list of conversations:

NOTE: although the .NET API wrapper contains methods for all read-operation on the Reevoo API, your ability to access any given method is based on the credentials you supply (the key and secret). If you attempt to access information you do not have access to, you will receive the message, "Request failed with status Forbidden and reason Forbidden.".

    var reevooApi = new ReevooApi();
    var response = reevooApi.Conversation.List("D10", "en", "AIPTPDV5700");

The API is discoverable, for example `reevooApi.` will supply an auto-completion list of the kinds of data you can obtain, for example `Reviewable`. Selecting this will provide an auto-completion list of methods, such as `List` or `Detail` available for the data.

## Troubleshooting

Forbidden/Forbidden: You do not have access to the requested data. Check your credentials, and your rights.

NotFound/Not Found: The requested data does not exist. Check your arguments.

