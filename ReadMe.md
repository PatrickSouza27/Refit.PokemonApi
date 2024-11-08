
# Refit Pokemon API

||Refit|Refit.HttpClientFactory|Refit.Newtonsoft.Json|
|-|-|-|-|
### [Github Refit](https://github.com/reactiveui/refit) 

<image src="https://github.com/reactiveui/refit/raw/main/refit_logo.png">

#### Api Pokemon https://pokeapi.co/


 ```plaintext
src
├── Services
│   ├── MyApiService.cs
│   └── AuthTokenProvider.cs
├── Interfaces
│   └── IMyApiClient.cs
├── Program.cs
└── Startup.csI

src
├── Domain
├── Application
├── Infrastructure
│   └── HttpClients
│       └── SeuClientRefit.cs
└── API
    ├── Controllers
    │   └── SeuController.cs
    ├── Startup.cs
    └── Program.cs
```

```URL
https://localhost:7014/pokemon?limit=2
