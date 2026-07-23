# FizzBuzz Detector

A C# solution that processes text to apply FizzBuzz substitution rules to words while keeping whitespace, punctuation, and contractions (like `It's`) intact.

## Features
* Replaces words based on index: `Fizz` (3), `Buzz` (5), `FizzBuzz` (15).
* Preserves original line breaks, spaces, and quote formatting.
* Validates string lengths (7–100 characters) and null inputs.

## Project Structure
* `intern_assignemtn`: Core logic (`FizzBuzzDetector.cs`) and entry point.
* `intern_assignemtn.Tests`: xUnit test suite.
