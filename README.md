# RazorReactHybridDemo
Demo of how to utilise react, typescript and the node ecosystem without going full SPA.

## Purpose
Create a MVC/Razor pages web app that can still compete with the likes of a SPA without having to take on the full complexity of an SPA.

Years back people used to use knockout js to do this. This approach is along the same lines but with React, Typescript and other node goodies.

## Get Started

### Dependencies

You'll need nodejs.

If you are running windows head to https://nodejs.org/en/download/ and install the package.

If you are running mac os I'd recommend using NVM, however you can install node from the like above as well.

```bash
# Install Brew if not install (https://brew.sh/)
# May require sudo to be run
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"

# Install yarn
brew install yarn

# If you get any permissions errors run the below to reset permissions and try again
sudo chmod -R g+rwx /usr/local/*

# Install nvm
curl -o- https://raw.githubusercontent.com/nvm-sh/nvm/v0.37.2/install.sh | bash

# Use Node Version Manager to install nodejs
# Using install 'node' will install latest avaiable version
nvm install node
```

And of course you'll need .NET Core. which you can find [here](https://dot.net)


### Run the app

The app runs in two parts, a nodejs app running with webpack running a webserver locally then with build a minified js 
library to be included in the .net app on deploy and the .NET core app with Razor Pages/MVC

You can run either individually however to using the react library you'll need to run the node app.

```
cd src/ReactApp

npm run start

// You can test this is running by going to http://localhost:3020 
```

And
```
cd src/RazorHybrid

dotnet run
```

