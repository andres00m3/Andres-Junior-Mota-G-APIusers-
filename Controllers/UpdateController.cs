using APIuser1.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIuser1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateController : ControllerBase
    {
        private readonly UserRepositorio UserRepositorio;
        public UpdateController()
        {
           UserRepositorio = new UserRepositorio();
        }


        // PUT api/<Empleados3Controller>/5

        [HttpPost]
        public void PutUsuario(int id, Usuario usuario)
        {

           usuario.Id = id;
            if (ModelState.IsValid)
                UserRepositorio.Update(usuario);

        }
    }
}
