namespace Actors

open Akka.Actor
open Akka.Event
open System

type MyActor() as self =
  inherit ReceiveActor()
  do self.Receive<string>(self.Handle)
  let logger = Logging.GetLogger(MyActor.Context)
  member this.Handle msg: unit =
    logger.Info ("Handle: {0}", msg)
  static member Props () =
    Props.Create(fun () -> MyActor())