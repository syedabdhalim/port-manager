
# Simple Port Manager

Simple Port Manager is a Windows Forms application written in C# that lists all the ports currently in use on the local machine. The application allows users to view details about the ports, including the protocol, local address, local port, state, PID, and process name. Additionally, users can search for specific ports and kill processes associated with those ports.

## Features

- List all ports in use with detailed information.
- Search for specific ports by number.
- Kill processes associated with specific ports.
- Refresh the port list.

## Screenshots
![image.png](https://i.postimg.cc/nLx6gLYg/image.png)
## Getting Started

### Prerequisites

- .NET Framework 5.0 or later
- Visual Studio 2019 or later

### Installation

1. Clone the repository:
   ```sh
   git clone https://github.com/syedabdhalim/simple-port-manager.git

2. Open the solution in Visual Studio
3. Build the solution to restore the required packages.
### Usage
-   The main window displays a list of all ports in use.
-   Use the search box to filter ports by number.
-   Click the "Kill" button next to a process to terminate it.
-   Use the "Refresh" button to manually refresh the port list.

## Unit Tests

Unit tests are written in `PortManagerTest.cs` using NUnit and Moq. The tests cover the core functionalities of the `PortManager` class.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes.