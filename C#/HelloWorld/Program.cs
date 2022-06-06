// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int [] numbers = {2,3,4,5,6,7,8,9,10,11,12,13,14,15,16};
//var squaredNumbers = numbers.Select(x => x * x );
//Console.WriteLine(String.Join(" ", squaredNumbers));
//Console.WriteLine($"Numbers {numbers}");
//float t = 3.123f;
//Console.WriteLine(t.ToString("#.###"));//tres decimales format
//un destructor tiene el mismo nombre de la clase se crea como una clase pero se antepone el signo ~
 
 
//
/*
var consulta = from number in numbers
where (number % 2 ==0) //todas las condiciones que se quieran
select number;

foreach(var t in consulta){
    Console.WriteLine("test "+ t);
}
*/
//Generics
    /*

    */
/*
    Generic<String> str = new Generic<string>();
    str.Campo = "dato";
    Console.WriteLine("test "+ str.Campo);
    public class Generic<T>{

        public T Campo {get;set;}

    }*/

//Collections

    var coches = new List <String> ();

    coches.Add("Ford");
    coches.Add("Mazda");
    coches.Add("Fiat");
    var coches2 = new List <String> ();

    coches.Add("Seat");
    coches.Add("Peugeot");

List<Elemento> elemento = CreateLista();

var query  = from el in elemento select el;

foreach (var el in query){
    Console.WriteLine(el.Nombre);
}


static List<Elemento> CreateLista(){
    return new List<Elemento>{
            {new Elemento() { Simbolo = "k", Nombre = "Potasio" , NumeroAtomico= 19}},
            {new Elemento() { Simbolo = "Ca", Nombre = "Calcio" , NumeroAtomico= 20}},
            {new Elemento() { Simbolo = "Ti", Nombre = "Titanio" , NumeroAtomico= 22}
        }
    };
}

    public class Elemento 
    {
        public String Simbolo {get;set;}
        public String Nombre {get;set;}
        public int NumeroAtomico {get;set;}


    }