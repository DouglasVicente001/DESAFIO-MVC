using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using VirtualMagazine.Data;
using VirtualMagazine.DTO;
using VirtualMagazine.Models;

namespace VirtualMagazine.Controllers
{   
    
    public class UnidadeDeMedidasController : Controller
    {     
        private readonly ApplicationDbContext database;

        public UnidadeDeMedidasController(ApplicationDbContext database) {
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar (IgredienteDTO unidadeDeMedidaTemporario){
            if(ModelState.IsValid){
                UnidadeDeMedida unidadeDeMedida = new UnidadeDeMedida();
                unidadeDeMedida.Nome = unidadeDeMedidaTemporario.Nome;
                unidadeDeMedida.Status = true;
                database.UnidadeDeMedidas.Add(unidadeDeMedida);
                database.SaveChanges();
                return RedirectToAction("UnidadeDeMedidas","Gestao");
                }else{
                ViewBag.Receitas = database.Receitas.ToList();
                return View("../Gestao/NovaUnidadeDeMedida");
            }
        }   public IActionResult Atualizar(IgredienteDTO unidadeDeMedidaTemporario) {
            if(ModelState.IsValid) {
                var unidadeDeMedida = database.UnidadeDeMedidas.First(unid => unid.Id == unidadeDeMedidaTemporario.Id);
                unidadeDeMedida.Nome = unidadeDeMedidaTemporario.Nome;
                database.SaveChanges();
                return RedirectToAction("UnidadeDeMedidas","Gestao");
            }else {
                return View("../Gestao/EditarUnidadeDeMedida");
            }
        }
        [HttpPost]
        public IActionResult Deletar(int id){
            if(id> 0){
                var unidadeDeMedida= database.UnidadeDeMedidas.First(forne => forne.Id == id);
                unidadeDeMedida.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("UnidadeDeMedidas","Gestao");
        }
    }
}