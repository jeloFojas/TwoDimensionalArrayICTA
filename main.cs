using System;

class Program {
  public static void Main (string[] args) {

    
    string [,] data = new string [5,2];    
    
    string [,] studentData = {
                                {"TONGOL", "MOSES"},
                                {"MAUNA", "HIZZAM"},
                                {"ABRILLO","LOWELL"},
                                {"CAVILLE","SHYRA"},
                                {"MONTEVERDE","GIRALENE"}        
                                };

    // studentData[2,0] = "CURRACHEA";
    // studentData[2,1] = "SHANE";

    Console.WriteLine(studentData[2,0]+studentData[2,1]);
    

    
  }
}