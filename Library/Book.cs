using System;

namespace Ucu.Poo.Expert
{
    public class Book           //Tenemos la clase Book
    {

        public string Title { get ; }
        public string Author { get ; }    
        public string Code { get ;  }        // La clase "Book" Contiene dos responsabilidades:
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;       // 1-Almacenar la información general del libro
            this.Code = code;           //Así como el autor y el título del libro
        }

        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;    //2- Y tambien tiene la responsabilidad de almacenar
            this.LibraryShelve = shelve;    //La ubicación del mismo en la biblioteca.
        }
                                            // Al tener estas dos responsabilidades, no cumple con el principio SRP
    }                                       // Ya que la clase tiene más de una razón para cambiar
}                                           
