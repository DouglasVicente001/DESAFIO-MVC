using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VirtualMagazine.Data;
using VirtualMagazine.DTO;
using VirtualMagazine.Models;

namespace VirtualMagazine.Controllers
{
    public class IgredientesController : Controller
    {
        private readonly ApplicationDbContext database;

        public IgredientesController(ApplicationDbContext database) {
            this.database = database;
        }
        [HttpPost]
        public IActionResult Salvar(UnidadeDeMedidaDTO igredienteTemporario) {
            if(ModelState.IsValid){
                Igrediente igrediente = new Igrediente();
                igrediente.Nome = igredienteTemporario.Nome;
                igrediente.Receita= database.Receitas.First(igred=> igred.Id == igredienteTemporario.ReceitaId);  
                igrediente.UnidadeDeMedida = database.UnidadeDeMedidas.First(UnidadeDeMedida=> UnidadeDeMedida.Id == igredienteTemporario.UnidadeDeMedidaId); 
                igrediente.Medicao = igredienteTemporario.Medicao;  
                igrediente.Status = true;
                database.Igredientes.Add(igrediente);
                database.SaveChanges();
                return RedirectToAction("Igredientes","Gestao");
                }else{
                ViewBag.Receitas = database.Receitas.ToList();
                ViewBag.UnidadeDeMedidas = database.UnidadeDeMedidas.ToList();
                return View("../Gestao/NovoIgrediente");
            }
        }
        [HttpPost]
        public IActionResult Atualizar(UnidadeDeMedidaDTO igredienteTemporario) {
            if(ModelState.IsValid){
                var igrediente = database.Igredientes.First(prod => prod.Id == igredienteTemporario.Id);
                igrediente.Nome = igredienteTemporario.Nome;
                
                igrediente.Receita = database.Receitas.First(i=> i.Id == igredienteTemporario.ReceitaId);  
                igrediente.Medicao = igredienteTemporario.Medicao;
                database.SaveChanges();
                return RedirectToAction("Igredientes","Gestao");
                }else  {
                ViewBag.Receitas = database.Receitas.ToList();
                ViewBag.UnidadeDeMedidas = database.UnidadeDeMedidas.ToList();
                return View("../Gestao/EditarIgrediente");
            }
        }
        [HttpPost]
        public IActionResult Deletar(int id){
            if(id> 0){
                var igrediente = database.Igredientes.First(p=> p.Id == id);
                igrediente.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Igredientes","Gestao");
        }
    }
}