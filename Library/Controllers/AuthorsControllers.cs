using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Library.DTOs;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Library.Controllers
{
    [Route("api/v1/library/[controller]")]
    public class AuthorsController : Controller
    {
        private readonly LibraryDbContext _context;
        private readonly IMapper _mapper;

        public AuthorsController(LibraryDbContext context, IMapper mapper){

            _context = context; 
            _mapper = mapper;
        }
        // GET all authors
        //List<AuthorDTO>
        [HttpGet]
        public List<AuthorDTO> Get()
        {
            List<AuthorDTO> uthor = _mapper.Map<List<Author>, List<AuthorDTO>>(_context.Authors.Include(db => db.Books).ToList());
            return uthor;    
        }
    
        // GET author by name
        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
           var author = this._context.Authors
            .Where(ct=> string.Equals(ct.AuthorName, name, StringComparison.CurrentCultureIgnoreCase))
            .ToArray();
            return Ok(author);      
        }
        
            // GET author by id
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try{
                var author = _context.Authors.Where(x=> x.AuthorId == id).Include(x=> x.Books).FirstOrDefault();
            // var author = this._context.Authors.SingleOrDefault(ct => ct.AuthorId).Include(db => db.Books).ToList());
                return Ok(author);
            
            }catch(Exception e){
                return Ok(e.Message);
            }
           
            // var author = this._context.Authors.SingleOrDefault(ct=> ct.AuthorId == id);
            // if(author !=null){
            //     return Ok(author);
            // }else{
            //     return NotFound();
            // }

        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Author author)
        {
            if(!this.ModelState.IsValid){
                return BadRequest();
            }
            this._context.Authors.Add(author);
            this._context.SaveChanges();
            return Created($"library/authors/{author.AuthorId}", author);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put( [FromRoute]int id, [FromBody] Author author)
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
            Author target = this._context.Authors.SingleOrDefault(ct=> ct.AuthorId ==id);
            if(target != null){
                this._context.Authors.Remove(target);
                this._context.SaveChanges();
                return Ok();
            }else{
                return NotFound();
            }
        }
    }
}

