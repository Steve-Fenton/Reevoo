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

    var reevooApi = new ReevooApi();
    var response = reevooApi.Conversation.List("D10", "en", "AIPTPDV5700");

The API is discoverable, for example `reevooApi.` will supply an auto-completion list of the kinds of data you can obtain, for example `Reviewable`. Selecting this will provide an auto-completion list of methods, such as `List` or `Detail` available for the data.