# DryIoc v4 vs DryIoc v2

### v2.12.6.0

#### Levels = 5, Imports = 20


```log
2021-08-20 21:44:16.252 +03:00 [INF] Starting up...
2021-08-20 21:44:16.420 +03:00 [INF] Started static benchmark.
2021-08-20 21:44:22.395 +03:00 [INF] Imported service: RootService
2021-08-20 21:44:22.413 +03:00 [INF] Imported lazy service: RootLazyService
2021-08-20 21:44:22.421 +03:00 [INF] Warming up...
2021-08-20 21:44:22.432 +03:00 [INF] Running the benchmark...
2021-08-20 21:44:23.521 +03:00 [INF] Time elapsed: "00:00:01.0847237"
2021-08-20 21:44:23.572 +03:00 [INF] Started static benchmark.
2021-08-20 21:44:23.585 +03:00 [INF] Imported lazy service: RootLazyService
2021-08-20 21:44:23.589 +03:00 [INF] Warming up...
2021-08-20 21:44:29.509 +03:00 [INF] Running the benchmark...
2021-08-20 21:44:30.641 +03:00 [INF] Time elapsed: "00:00:01.1304883"
```

#### Levels = 10, Imports = 30

Never finished

### v3.0.2.0

#### Levels = 5, Imports = 20

Never finished

### v4.8.1.0

#### Levels = 5, Imports = 20

```log
2021-08-20 21:54:05.828 +03:00 [INF] Starting up...
2021-08-20 21:54:06.087 +03:00 [INF] Started static benchmark.
2021-08-20 21:54:06.349 +03:00 [INF] Imported service: RootService
2021-08-20 21:54:06.358 +03:00 [INF] Imported lazy service: RootLazyService
2021-08-20 21:54:06.361 +03:00 [INF] Warming up...
2021-08-20 21:54:06.367 +03:00 [INF] Running the benchmark...
2021-08-20 21:54:07.114 +03:00 [INF] Time elapsed: "00:00:00.7429218"
2021-08-20 21:54:07.161 +03:00 [INF] Started static benchmark.
2021-08-20 21:54:07.163 +03:00 [INF] Imported lazy service: RootLazyService
2021-08-20 21:54:07.165 +03:00 [INF] Warming up...
2021-08-20 21:54:07.176 +03:00 [INF] Running the benchmark...
2021-08-20 21:54:07.928 +03:00 [INF] Time elapsed: "00:00:00.7503767"
```

#### Levels = 10, Imports = 30

```log
D:\Externals\DryIocBench\Bin\v4\net46>DryIoc4Perf.exe     
2021-08-20 21:39:53.372 +03:00 [INF] Starting up...
2021-08-20 21:39:53.776 +03:00 [INF] Started static benchmark.
2021-08-20 21:39:54.317 +03:00 [INF] Imported service: RootService
2021-08-20 21:39:54.328 +03:00 [INF] Imported lazy service: RootLazyService
2021-08-20 21:39:54.330 +03:00 [INF] Warming up...
2021-08-20 21:39:54.361 +03:00 [INF] Running the benchmark...
2021-08-20 21:39:58.185 +03:00 [INF] Time elapsed: "00:00:03.8193749"
2021-08-20 21:39:58.406 +03:00 [INF] Started static benchmark.
2021-08-20 21:39:58.408 +03:00 [INF] Imported lazy service: RootLazyService
2021-08-20 21:39:58.410 +03:00 [INF] Warming up...
2021-08-20 21:39:58.475 +03:00 [INF] Running the benchmark...
2021-08-20 21:40:02.275 +03:00 [INF] Time elapsed: "00:00:03.7975021"
```

* v4.8.1 performs ~72 times slower than v2.12.6
* v3.0.2 performs ~876 times slower than v2.12.6
