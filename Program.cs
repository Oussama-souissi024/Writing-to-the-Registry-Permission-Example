using Microsoft.Win32;
using System;


class Program
{
    static void Main()
    {
        // Specify the Registry key and path

        
        string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\OussamaSoftware";
		// string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\OussamaSoftware";

		string valueName = "OussamaValueName";
        string valueData = "OussamaValueData";


        try
        {
            // Write the value to the Registry
            Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String );


            Console.WriteLine($"Value {valueName} successfully written to the Registry.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        Console.ReadKey();
    }
}