// Learn more about F# at http://fsharp.org

open System
open MessagePack

[<MessagePackObject>]
type User = {
    [<Key(0)>]
    name: string
    [<Key(1)>]
    age: int
}

[<EntryPoint>]
let main argv =
    let john = {name = "John Doe"; age=42}
    let bytes = MessagePackSerializer.Serialize(john)

    printfn "John got serialized into %d bytes" (Array.length bytes)

    let john' = MessagePackSerializer.Deserialize<User>(bytes)

    printfn "After deseriaizing we got:\n%A" john'

    printfn "are those two identical: %b" (john = john')
    0 // return an integer exit code
