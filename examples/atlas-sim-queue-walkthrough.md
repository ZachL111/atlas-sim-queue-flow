# Atlas Sim Queue Flow Walkthrough

I use this file as a small checklist before changing the C# implementation.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 163 | ship |
| stress | state drift | 140 | ship |
| edge | review cost | 168 | ship |
| recovery | decision risk | 184 | ship |
| stale | input pressure | 144 | ship |

Start with `recovery` and `stress`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

`recovery` is the optimistic case; use it to make sure the scoring path still rewards strong signal.
