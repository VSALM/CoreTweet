CoreTweet
=========

![statusimage](https://vsalmopen.visualstudio.com/DefaultCollection/_apis/public/build/definitions/3b3ae425-0079-421f-9101-bcf15d6df041/13/badge)

Yet another .NET Twitter Library...

Simplest authorizing:
```csharp
var session = OAuth.Authorize("consumer_key", "consumer_secret");
var tokens = OAuth.GetTokens(session, "PINCODE");
```

Tweeting is very easy:
```csharp
tokens.Statuses.Update(status => "hello");
```

Go with the Streaming API and LINQ:
```csharp
foreach(var status in tokens.Streaming.StartStream(StreamingType.Sample)
                                      .OfType<StatusMessage>()
                                      .Select(x => x.Status))
    Console.WriteLine("{0}: {1}", status.User.ScreenName, status.Text);
```

Get fantastic experiences with Rx:
```csharp
using CoreTweet.Streaming.Reactive;

var stream = t.Streaming.StartObservableStream(StreamingType.Filter, new StreamingParameters(track => "tea")).Publish();

stream.OfType<StatusMessage>()
    .Subscribe(x => Console.WriteLine("{0} says about tea: {1}", x.Status.User.ScreenName, x.Status.Text));

var disposable = stream.Connect();
await Task.Delay(30 * 1000);
disposable.Dispose();
```

Oh yes why don't you throw away any ```StatusUpdateOptions``` and it kinds???

## Platforms

We support both of Windows .NET and Mono, and CoreTweet works on following platforms:

* net35 (without Rx support)
* net40
* net45
* portable-net4
* sl5
* wp8
* win8
* MonoAndroid
* MonoTouch

## Files

CoreTweet.dll ... the main library

CoreTweet.Streaming.Reactive.dll ... the extension for Rx

## Install

Now available in [NuGet](https://www.nuget.org/packages/CoreTweet)!

Or please download a binary from [Releases](https://github.com/lambdalice/CoreTweet/releases).

## Build

You can't build PCL binaries (portable-net4, sl5, etc) on Mono (on Linux) because they requires non-free libraries.

### On Windows

#### Requires

* .NET Framework 4.5
* Windows PowerShell
* Visual Studio 2013
* Xamarin Starter

#### Step

* Run PowerShell as an admin and execute

```
Set-ExecutionPolicy AllSigned
```

* Run build.ps1

### On Linux and other Unix-like

#### Requires

* Mono 3.x
* make
* XBuild
* Doxygen (if not installed, automatically build from source)

#### Step

* Run make

## Contributing

CoreTweet is not stable and need tests. Report to [Issues](https://github.com/CoreTweet/CoreTweet/issues?state=open) if you find any problems.

We seriously need your help for writing documents.

Please go to [Wiki](https://github.com/CoreTweet/CoreTweet/wiki) and write API documents, articles or/and some tips!

Pull requests are welcome. Write, write, write and send!

## Website

To see the document of CoreTweet, visit [our website](http://coretweet.github.io/) now!

## License

This software is licensed under the MIT License.
