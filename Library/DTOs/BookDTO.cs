
using Library.Models;
using System.Collections.Generic;
using Library.DTOs;

namespace Library.DTOs
{
    public class BookDTO
    {

    public int Id {get; set;}
    public string Title { get; set; }   
    public string Description { get; set; }

    public string Section { get; set; } 
    public string Genre { get; set; }
    public int Year { get; set; }   
    public string Publisher { get; set; }

  

    }
}