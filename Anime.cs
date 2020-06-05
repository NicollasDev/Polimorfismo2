namespace Polimorfismo_2
{
    public class Anime
    {

     public string Poder(){
         return"O Chakra total é de 1000";
     }
     public string Poder(int Chakra){
         return"O Sasuke possui "+Chakra  ;
     }
     public string Poder(int Chakra, int Chakrakyuubi){
         return "O Naruto possui "+(Chakra+Chakrakyuubi);
     }
     
    }
}