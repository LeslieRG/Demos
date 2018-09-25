
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Library.DTOs;




namespace Library.Controllers{

    [Route("api/v1/library/[controller]")]
     public  class BooksController : Controller{

        private readonly LibraryDbContext _context;
        private readonly IMapper _mapper;


     public BooksController(LibraryDbContext context, IMapper mapper)
     {
           _context = context;
           _mapper = mapper;
           
         }
        //get all the books
        [HttpGet]
         public List<BookDTO> Get(){

        var keeper = _mapper.Map<List<BookDTO>>( _context.Books.ToList());
   
         return keeper;
         }

         //Get books by id

        [HttpGet("{id}")]
        public IActionResult Get(int id){
            var book = this._context.Books.SingleOrDefault(ct =>ct.Id_Book == id);
            if(book !=null){
                return Ok(book);

            }else{
                return NotFound();
            }
        }

///Get the books by name

     [HttpGet("name/{name}")]
         public IActionResult Get(string name){

             var keeper = this._context.Books
             .Where(ct=> string.Equals(ct.Title, name, StringComparison.CurrentCultureIgnoreCase))
            .ToArray();
            return Ok(keeper);      
         }

// POST api/values

        [HttpPost]
        public IActionResult Post([FromBody]Book book)
        {
            if(!this.ModelState.IsValid){
                return BadRequest();
            }
            this._context.Books.Add(book);
            this._context.SaveChanges();
            return Created($"library/books/{book.Id_Book}", book);
        }

 // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put( [FromRoute]int id, [FromBody] Book book)
        {
            if(!this.ModelState.IsValid){
                return BadRequest();
            }else{
                return NotFound();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Book target = this._context.Books.SingleOrDefault(ct=> ct.Id_Book ==id);
            if(target != null){
                this._context.Books.Remove(target);
                this._context.SaveChanges();
                return Ok();
            }else{
                return NotFound();
            }
        }

    }

}