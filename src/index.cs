// Namespace Declaration
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
// Program start class
class fileSearchSystem
{
    static string fileValue = null;
    // Main begins program execution.
    static void Main()
    {
        
        newSearch();

    }
    static void newSearch() {
    
        Console.WriteLine("file search system: ");
        
            string fileName = Console.ReadLine();
            if (File.Exists(fileName)) {
            fileValue = System.IO.File.ReadAllText(fileName);
            string[] fileTolkens = fileName.Split(".");
            if (fileTolkens[1] == "sml") {
                Console.WriteLine("simplo markup language file detected, displaying page");
                Console.WriteLine("fileName: " + fileName);
                Process.Start("/bin/bash", "-c \"python3 simploMarkupLanguage.py \"" + fileName);
            } else {
                Console.WriteLine(fileValue);
            }
            newSearch();
            } else {
                Console.WriteLine("Oh, no!");
                Console.WriteLine("404 error: unknown file " + fileName + " please make sure that you have the directory right and that the file exists");
                newSearch();
            }
        }
    }
