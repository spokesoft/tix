# Tix

A command-line ticket tracking system for developers who prefer terminals over browsers.

## What is it?

Tix is an open source project management tool built as a .NET global tool. It handles tickets, projects, and all that stuff without making you leave your terminal.

## Features

- Track tickets
- Manage projects
- Command-line interface
- Works offline with local SQLite database
- Doesn't require a web browser

## Installation

```
dotnet tool install -g tix
```

## Usage

```
tix create project TheProject
tix create ticket "Fix that bug" --project TheProject
tix list tickets --project TheProject
```