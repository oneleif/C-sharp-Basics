using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class AsyncIOExample
{
    private static string inputFile = @"C:\Users\ambid\Documents\Coding\C-sharp-Basics\c-sharp-tutorial-4\uncompressed.txt";
    private static string outputFile = @"C:\Users\ambid\Documents\Coding\C-sharp-Basics\c-sharp-tutorial-4\compressed.txt";
    
    public static void RunNormalTasks()
    {
        CompressFile(inputFile, outputFile);
        TaskOne();
        TaskTwo(); // TaskTwo has to wait for TaskOne to finish
    }

    public static void RunAsyncTasks()
    {
        Task compressFile = CompressFileAsync(inputFile, outputFile);
        TaskOne();
        TaskTwo(); // TaskTwo has to wait for TaskOne to finish
    }

    public static void CompressFile(string inputFile, string outputFile)
    {
        // Use the following streams, and tell them to Dispose, they inherit from IDisposable.
        using (var inputStream = File.Open(inputFile, FileMode.Open, FileAccess.Read))
        using (var outputStream = File.Create(outputFile))
        using (var deflateStream = new DeflateStream(outputStream, CompressionMode.Compress))
        {
            inputStream.CopyTo(deflateStream);

            deflateStream.Close();
            outputStream.Close();
            inputStream.Close();
        }
    }

    public static async Task CompressFileAsync(string inputFile, string outputFile)
    {
        // Beginning in C# 8.0, the using statement ensures the correct use of IAsyncDisposable objects.
        using (var inputStream = File.Open(inputFile, FileMode.Open, FileAccess.Read))
        using (var outputStream = File.Create(outputFile))
        using (var deflateStream = new DeflateStream(outputStream, CompressionMode.Compress))
        {
            await inputStream.CopyToAsync(deflateStream);

            deflateStream.Close();
            outputStream.Close();
            inputStream.Close();
        }
    }

    static void TaskOne()
    {
        Console.WriteLine("TaskOne");
    }

    static void TaskTwo()
    {
        Console.WriteLine("TaskTwo");
    }

}
