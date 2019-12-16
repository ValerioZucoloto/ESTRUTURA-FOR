using System;

class MainClass {
  public static void Main (string[] args) {
    string piao = "0", piao2 = "0"; 
    int n=0;

    Console.WriteLine ("Informa quantas linhas: ");
    n = int.Parse (Console.ReadLine());

    for (int i=0; i < n; i++){
      Console.WriteLine (piao);

      piao +=piao2; 
    }     
          
  }
}