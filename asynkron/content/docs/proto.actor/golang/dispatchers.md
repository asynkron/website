---
layout: docs.hbs
title: Dispatchers
---

# Dispatchers

## What Do Dispatchers Do?
Dispatchers are responsible for scheduling all code that run inside the `ActorSystem`. Dispatchers are one of the most important parts of Akka.NET, as they control the throughput and time share for each of the actors, giving each one a fair share of resources.

By default, all actors share a single **Global Dispatcher**. Unless you change the configuration, this dispatcher uses the *.NET Thread Pool* behind the scenes, which is optimized for most common scenarios. **That means the default configuration should be *good enough* for most cases.**

#### Why should I use different dispatchers?

When messages arrive in the [actor's mailbox](Mailbox), the dispatcher schedules the delivery of messages in batches, and tries to deliver the entire batch before releasing the thread to another actor. While the default configuration is *good enough* for most scenarios, you may want to change ([through configuration](#configuring-dispatchers)) how much time the scheduler should spend running each actor.

