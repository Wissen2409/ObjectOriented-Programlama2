

/*

Çıktılar : Exe yada DLL'dir

// Namespace'ler var

namespace Örnek{


    //Class yada struct olabilir
    public class ClasOrnek
    {
        // değişkenler olabilir
        int a;

        // metotlar olabilir
        public static void OrnekMetot(){
        
        
        }

        // properties'ler olabilir



    }

    public struct StructOrnek
    {

        // değişken olabilir

        //metot olabilir

        public static void DenemeMetot(){
        
        
        }
    
    
    }









}






*/


// Örnek : 

// iki tane Daire ve Üçgen adında bir sınıf yazınız

//bu sınıfların içerisinde, alan ve çevre hesabı olan ikişer metot olsun 

// Daire ve Ucgen sınıflarının hesaplama yapmak için nesnelerini üretelim 


Daire d = new Daire(){

  // bu yöntem ile nesne oluşturmada, sadece nesnenin, değişkenlerine erişebilirsiniz
  // metotlarına erişemezsiniz    
};

Daire daire = new Daire();
double daireAlan = daire.Alan(3);
Console.WriteLine("Daire Alan : "+daireAlan);

double daireCevre = daire.Cevre(6);
Console.WriteLine("Daire Çevre :"+daireCevre);


Ucgen ucgen = new Ucgen();
int ucgenAlan = ucgen.Alan(9,2);
Console.WriteLine("Ucgenin Alanı : {0}",ucgenAlan);

int ucgenCevre = ucgen.Cevre(3,56,8);
Console.WriteLine("Üçgenin Çevresi : "+ucgenCevre);
