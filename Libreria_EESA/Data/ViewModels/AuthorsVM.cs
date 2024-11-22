using System.Collections.Generic;

namespace Libreria_EESA.Data.ViewModels
{
    public class AuthorsVM
    {
        public string FullName { get; set; }
    }
    public class AuthorWithBooksVM
    {
        public string FullName { get; set; }
        public List<string> BookTitles { get; set; }
    }
}
