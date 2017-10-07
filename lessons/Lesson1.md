# Checking Out the Code
Checking out some code and working on it.

## Step 1: Fork This Repo on GitHub
Click Fork on GitHub.

## Step 2: Checkout this Repo
Replace `<username>` with your usernameL

```sh
$ git clone https://github.com/<username>/LearningFSharp.git
```

## Step 3: Add this repo as upstream

```sh
$ cd LearningFSharp
$ git remote add upstream https://github.com/jakzale/LearningFSharp.git
```

## Step 4: List remotes to see if everything is OK

```sh
$ git remote -v
```

## Step 5: Fetch Upstream

```sh
$ git fetch upstream
```

# Side Note: dotnet command
We will be using the `dotnet` command line tool a lot.  It is important that you
familiarise yourself with it.  If you are not sure what to do or what is the
syntax for the particular command, you can always run `dotnet --help`.

Examples:
- `dotnet --help`
- `dotnet add --help`
- `dotnet new --help`

# Adding a package to dotnet project
There is a small example in `src/LearningMsgPack` that uses the `MessagePack`
package, however the package is missing from the
`src/LearningMsgPack/LearningMsgPack.fsproj`.

You should add the missing package using the dotnet command

```sh
$ dotnet add src/LearningMsgPack package MessagePack
```

After that you should verify if everything works by building the whole solution:
```
$ dotnet build LearningFSharp.sln
```

And you can see MessagePack in action by running the project
```
$ dotnet run --project src/LearningMsgPack/LearningMsgPack.fsproj
```

You should also check the `src/LearningMsgPack/LearningMsgPack.fsproj` to see how `dotnet` added the package reference.  It should contain lines similar to this:

```xml
  <ItemGroup>
    <PackageReference Include="MessagePack" Version="1.6.1.2" />
  </ItemGroup>
```