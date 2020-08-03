---
layout: docs.hbs
title: The Obligatory Hello World
---
#  The Obligatory Hello World
This example shows how to define and consume actors in C#

## Hello World 

### Define a message:

{{< tabs >}}
{{< tab "C#" >}}
```csharp
class Hello
{
    public string Who;
}
```
{{</ tab >}}
{{< tab "Go" >}}
```go
//define a struct for our message
type Hello struct{ Who string }
```
{{</ tab >}}
{{</ tabs >}}

### Define your actor

{{< tabs >}}
{{< tab "C#" >}}
```csharp
class HelloActor : IActor
{
    public Task ReceiveAsync(IContext context)
    {
        var msg = context.Message;
        if (msg is Hello r)
        {
            Console.WriteLine($"Hello {r.Who}");
        }
        return Actor.Done;
    }
}
```
{{</ tab >}}
{{< tab "Go" >}}
```go
func (state *HelloActor) Receive(context actor.Context) {
    switch msg := context.Message().(type) {
    case Hello:
        fmt.Printf("Hello %v\n", msg.Who)
    }
}
```
{{</ tab >}}
{{</ tabs >}}

### Usage:

{{< tabs >}}
{{< tab "C#" >}}
```csharp
var props = Actor.FromProducer(() => new HelloActor());
var pid = Actor.Spawn(props);
pid.Tell(new Hello
{
    Who = "Alex"
});
```
{{</ tab >}}
{{< tab "Go" >}}
```go
func main() {
    props := actor.FromInstance(&HelloActor{})
    pid := actor.Spawn(props)
    pid.Tell(Hello{Who: "Roger"})
    console.ReadLine()
}
```
{{</ tab >}}
{{</ tabs >}}