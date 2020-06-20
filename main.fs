open Akka.Actor
open Actors
open System

(*
Use cmd + shift + s to open terminal
sh run.sh
*)

let system = ActorSystem.Create("MyActorSystem")
                        
let myActor = system.ActorOf(MyActor.Props(), "MyActor")

myActor.Tell "Hello"

Console.ReadLine() |> ignore

system.Terminate() |> ignore