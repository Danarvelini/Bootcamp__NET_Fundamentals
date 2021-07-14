using System;

public class Enumerador{
    public enum Cor{
    Vermelho,
    Verde,
    Azul,
    Cinza
}
    
    public static void EscreverCor(Cor cor){
        switch(cor){
            case Cor.Vermelho:
                Console.WriteLine("Vermelho");
                break;
            case Cor.Verde:
                Console.WriteLine("Verde");
                break;
        }
    }
}