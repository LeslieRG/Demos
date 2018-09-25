using System.ComponentModel.DataAnnotations;
using Library.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
public class Author
{

    [Column("Id_Author")]
    [Key]
    public int AuthorId { get; set; }

    [Column("Name")]
    public string AuthorName { get; set; }

    [Column("Last_Name")]
    public string AuthorLastName { get; set; }

    [Column("Email")]
    public string AuthorEmail { get; set; }
    
    public List<Book>  Books{get; set;}
    }
}