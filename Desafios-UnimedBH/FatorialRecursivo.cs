using System; 

class FatorialRecursivo
{
  static void Main(string[] args) 
  { 
     int fat = fatorial (Convert.ToInt32(Console.ReadLine()));
     Console.WriteLine(fat);
  }
    
  /*
  * Função recursiva para cálculo do Fatorial
  */
  static int fatorial (int x) {
    if (x==1 || x==0){
      return 1;
    } else{
      return x * fatorial (x-1);
    }
  }//fim da Função fatorial
}