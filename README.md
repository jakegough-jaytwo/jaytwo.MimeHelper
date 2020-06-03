# jaytwo.MimeHelper

[![NuGet version (jaytwo.MimeHelper)](https://img.shields.io/nuget/v/jaytwo.MimeHelper.svg?style=flat-square)](https://www.nuget.org/packages/jaytwo.MimeHelper/)

I got tired of media type magic strings.

Used the [NGINX mime type config](https://github.com/nginx/nginx/blob/master/conf/mime.types) as a baseline.

## Installation

Add the NuGet package

```
PM> Install-Package jaytwo.MimeHelper
```

## Usage

```csharp
MediaTypeProvider.GetMediaTypeFromExtension("txt"); // returns "text/plain"

MediaType.text_html; // returns "text/plain"
MediaType.image_jpeg; // returns "image/jpeg"
MediaType.application_json; // returns "application/json"
```

---

Made with &hearts; by Jake
