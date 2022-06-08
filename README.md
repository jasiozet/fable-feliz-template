# Fable Feliz Feliz.DaisyUI Vite App

This is a template Fable project for me which uses [Vite](https://fable.io/Fable.Lit/docs/hmr.html) so you can easily get started and add your own code progressively.


## Requirements

* [dotnet SDK](https://www.microsoft.com/net/download/core) 5.0 or higher
* [node.js](https://nodejs.org)
* An F# editor like Visual Studio, Visual Studio Code with [Ionide](http://ionide.io/) or [JetBrains Rider](https://www.jetbrains.com/rider/)


## Building and running the app

* Install dependencies: `npm install`
* npm i -D vite
* npx vite --open     # Start dev server and open browser
* npx vite build      # Build your site for production

Any modification you do to the F# code will be reflected in the web page after saving.

## Project structure

```
.
├── Nuget.Config
├── README.md
├── package-lock.json
├── package.json - JS dependencies
├── build - Ready to deploy files when you run `npm run build`
├── dist - Compiled JS from F# file
├── public
│   ├── favicon.ico - Fable favicon
│   ├── index.html - Main HTML file
│   └── robots.txt
└── src
    ├── App.fs - F# sample code
    └── App.fsproj - F# project
```

## Stuff I (jasiozet) added:
* Feliz https://zaid-ajaj.github.io/Feliz/#/
* Feliz.DaisyUI https://dzoukr.github.io/Feliz.DaisyUI/#/
* Vite https://fable.io/Fable.Lit/docs/hmr.html

Commands for that:
* femto install Feliz
* femto Feliz.DaisyUI
* npm i -D vite