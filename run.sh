fsharpc --nologo -r Newtonsoft.Json.dll -r System.Security.Permissions.dll -r System.Configuration.ConfigurationManager.dll -r System.Collections.Immutable.dll -r Akka.dll --out:main.exe MyActor.fs main.fs && mono main.exe