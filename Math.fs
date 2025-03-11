module CS220.Quiz1.Math

open System

let f (n: uint64) =
  if n % 2UL = 0UL then n / 2UL
  else 3UL * n + 1UL

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let rec iter (n: uint64) count =
    if n = (uint64 1) then count
    else iter (f n) (count+1)
  iter (uint64 n) 0
