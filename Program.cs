using Azure.Storage.Blobs;
using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Replace with your Azure Storage account's connection string
        string connectionString = "<your-storage-account-connection-string>"; 
        
        // Name of the blob container in your Azure Blob Storage
        string containerName = "my-container"; 
        
        // Local file path of the file you want to upload
        string filePath = @"C:\path\to\your\file.txt"; 
        
        // Name that the file will have when uploaded to Azure Blob Storage
        string blobName = "file.txt"; 
        
        // Create a BlobServiceClient to interact with the Blob service
        BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
        
        // Get the reference to the container (ensure the container exists in your Azure Blob Storage)
        BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
        
        // Get a reference to the blob (the file you want to upload)
        BlobClient blobClient = containerClient.GetBlobClient(blobName);

        // Upload the file asynchronously
        Console.WriteLine($"Uploading file to {blobName}...");
        await blobClient.UploadAsync(filePath, overwrite: true);
        Console.WriteLine("Upload completed.");
    }
}


