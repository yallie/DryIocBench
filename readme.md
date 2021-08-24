# DryIoc v4 vs DryIoc v2
 
 Version | Resolve[] | Import[] | Import[] with metadata |
|--------|-----------|----------|------------------------|
| 2.12.6 | 0.245     | 0.410    | 0.388                  |
| 4.8.1  | 0.137     | 3.655    | 9.204                  |

### v2.12.6.0

```log
2021-08-24 02:46:37.662 +03:00 [INF] Starting up...
2021-08-24 02:46:37.836 +03:00 [INF] Started ResolveMany with metadata benchmark.
2021-08-24 02:46:37.993 +03:00 [INF] Imported common services: 27
2021-08-24 02:46:38.065 +03:00 [INF] Warming up...
2021-08-24 02:46:38.067 +03:00 [INF] Running the benchmark...
2021-08-24 02:46:38.317 +03:00 [INF] Time elapsed: "00:00:00.2454775"
2021-08-24 02:46:38.319 +03:00 [INF] Started ImportMany benchmark.
2021-08-24 02:46:38.355 +03:00 [INF] Imported common services: 27
2021-08-24 02:46:38.363 +03:00 [INF] Warming up...
2021-08-24 02:46:38.374 +03:00 [INF] Running the benchmark...
2021-08-24 02:46:38.795 +03:00 [INF] Time elapsed: "00:00:00.4104957"
2021-08-24 02:46:38.798 +03:00 [INF] Started ImportMany with metadata benchmark.
2021-08-24 02:46:38.820 +03:00 [INF] Imported common services: 27
2021-08-24 02:46:38.839 +03:00 [INF] Warming up...
2021-08-24 02:46:38.842 +03:00 [INF] Running the benchmark...
2021-08-24 02:46:39.231 +03:00 [INF] Time elapsed: "00:00:00.3880157"
```

### v4.8.1.0

```log
2021-08-24 02:46:52.822 +03:00 [INF] Starting up...
2021-08-24 02:46:53.015 +03:00 [INF] Started ResolveMany with metadata benchmark.
2021-08-24 02:46:53.145 +03:00 [INF] Imported common services: 27
2021-08-24 02:46:53.177 +03:00 [INF] Warming up...
2021-08-24 02:46:53.240 +03:00 [INF] Running the benchmark...
2021-08-24 02:46:53.380 +03:00 [INF] Time elapsed: "00:00:00.1376572"
2021-08-24 02:46:53.382 +03:00 [INF] Started ImportMany benchmark.
2021-08-24 02:46:53.396 +03:00 [INF] Imported common services: 27
2021-08-24 02:46:53.398 +03:00 [INF] Warming up...
2021-08-24 02:46:53.403 +03:00 [INF] Running the benchmark...
2021-08-24 02:46:57.059 +03:00 [INF] Time elapsed: "00:00:03.6551647"
2021-08-24 02:46:57.062 +03:00 [INF] Started ImportMany with metadata benchmark.
2021-08-24 02:46:57.065 +03:00 [INF] Imported common services: 27
2021-08-24 02:46:57.078 +03:00 [INF] Warming up...
2021-08-24 02:46:57.084 +03:00 [INF] Running the benchmark...
2021-08-24 02:47:06.291 +03:00 [INF] Time elapsed: "00:00:09.2048379"
```
