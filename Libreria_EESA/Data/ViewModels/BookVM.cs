using System;
using System.Collections.Generic;

namespace Libreria_EESA.Data.ViewModels
{
    public class BookVM
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genero { get; set; }
        public string CoverURL { get; set; }
        public int PublisherID { get; set; }
        public List<int> AuthorIDs { get; set; }
    }
    public class BookWithAuthorsVM
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genero { get; set; }
        public string CoverURL { get; set; }
        public string PublisherName { get; set; }
        public List<string> AutorNames { get; set; }
    }
}
