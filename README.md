# jaytwo.MimeHelper

<p align="center">
  <a href="https://jenkins.jaytwo.com/job/jaytwo.MimeHelper/job/master/" alt="Build Status (master)">
    <img src="https://jenkins.jaytwo.com/buildStatus/icon?job=jaytwo.MimeHelper%2Fmaster&subject=build%20(master)" /></a>
  <a href="https://jenkins.jaytwo.com/job/jaytwo.MimeHelper/job/develop/" alt="Build Status (develop)">
    <img src="https://jenkins.jaytwo.com/buildStatus/icon?job=jaytwo.MimeHelper%2Fdevelop&subject=build%20(develop)" /></a>
</p>

<p align="center">
  <a href="https://www.nuget.org/packages/jaytwo.MimeHelper/" alt="NuGet Package jaytwo.MimeHelper">
    <img src="https://img.shields.io/nuget/v/jaytwo.MimeHelper.svg?logo=nuget&label=jaytwo.MimeHelper" /></a>
  <a href="https://www.nuget.org/packages/jaytwo.MimeHelper/" alt="NuGet Package jaytwo.MimeHelper (beta)">
    <img src="https://img.shields.io/nuget/vpre/jaytwo.MimeHelper.svg?logo=nuget&label=jaytwo.MimeHelper" /></a>
</p>

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
