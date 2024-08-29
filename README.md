# SMTP
This project is a .NET Core Web API built with ASP.NET Core, designed to send emails using SMTP protocols. The application supports sending emails through both Gmail and Outlook SMTP servers, allowing users to send emails programmatically.
## Features

- **Send Emails via Gmail**: Send emails using Gmail's SMTP server with SSL/TLS security.
- **Send Emails via Outlook**: Integrate with Outlook's SMTP server for sending emails.
- **API Endpoints**: Exposed API endpoints for sending emails by providing recipient addresses.
- **Error Handling**: Basic error handling to catch and report issues during email sending.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- A Gmail or Outlook account with SMTP access enabled.

## Installation

1. **Clone the repository**

   ```bash
   git clone https://github.com/username/SendEmailBySMTP.git
2 - Navigate to the project directory
    cd SendEmailBySMTP
3 - Restore dependencies
  dotnet restore

*** Please replace email with your actual email ***
  
4- Build the project
  dotnet build
5 - Run the application
  dotnet run

