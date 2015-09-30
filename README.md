# Reevoo
A .NET wrapper for the Reevoo V4 API

Example usage:

    var reevooApi = new ReevooApi(key, secret);
    var response = reevooApi.Conversation.List("D10", "en", "AIPTPDV5700");

The API is discoverable, for example `reevooApi.` will supply an auto-completion list of the kinds of data you can obtain, for example `Reviewable`. Selecting this will provide an auto-completion list of methods, such as `List` or `Detail` available for the data.