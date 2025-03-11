# Project-2-Azure-Storage-for-file-management-Code-to-Upload-Files

This repository contains the C# console application code that demonstrates how to upload files to Azure Blob Storage. The application uses **Azure.Storage.Blobs** to interact with Azure Blob Storage and upload files from your local machine to a specified container in Azure Blob Storage.

## Prerequisites

Before you run the application, ensure you have the following:
- **.NET SDK** installed (version 5.0 or later) - You can download it from [here](https://dotnet.microsoft.com/download).
- **Azure.Storage.Blobs NuGet package** - This is used to interact with Azure Blob Storage.
- An **Azure Storage Account** with an existing **Blob Container** where you want to upload files.

## Getting Started

### 1. Set up your Azure Storage Account
- Create a **Storage Account** in the Azure portal.
- Create a **Blob Container** to upload files to.
- Obtain the **Connection String** for your Storage Account. You can find this under **Access keys** in the **Settings** of your Storage Account.

### 2. Clone the Repository

```bash
git clone https://github.com/1suleyman/Project-2-Azure-Storage-for-file-management-Code-to-Upload-Files.git
cd Project-2-Azure-Storage-for-file-management-Code-to-Upload-Files
```

### 3. Install Dependencies

In the project folder, run the following command to install the **Azure.Storage.Blobs** NuGet package:

```bash
dotnet add package Azure.Storage.Blobs
```

### 4. Configure the Application

- Open the `Program.cs` file.
- Replace the placeholder for **connectionString** with the actual connection string from your Azure Storage Account.
- Specify the **containerName** and the **filePath** of the local file you want to upload.

```csharp
string connectionString = "<your-storage-account-connection-string>";
string containerName = "my-container"; 
string filePath = @"C:\path\to\your\file.txt";
string blobName = "file.txt";
```

### 5. Run the Application

To upload the file to Azure Blob Storage, run the following command:

```bash
dotnet run
```

The file will be uploaded to the specified blob container in Azure.

## Conclusion

This project demonstrates how to upload files to Azure Blob Storage using C# and the **Azure.Storage.Blobs** package. You can use this code to manage your files in Azure Blob Storage by modifying the application according to your needs.

For more details on interacting with Azure Blob Storage, refer to the official Azure documentation: [Azure Blob Storage Documentation](https://docs.microsoft.com/en-us/azure/storage/blobs/).
