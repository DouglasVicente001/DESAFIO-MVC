using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using VirtualMagazine.Data;
using VirtualMagazine.DTO;
using VirtualMagazine.Models;

namespace VirtualMagazine.Controllers
{
    public class ReceitasController : Controller
    {      
        private readonly ApplicationDbContext database;

        public ReceitasController(ApplicationDbContext database) {
            this.database = database;
        }
        [HttpPost]
        public IActionResult Salvar(ReceitaDTO receitasTemporaria)
        {
            if(ModelState.IsValid){
                Receita receitas = new Receita();
                receitas.Nome = receitasTemporaria.Nome;
                receitas.ModoPreparo = receitasTemporaria.ModoPreparo;
                receitas.TempoPreparo = receitasTemporaria.TempoPreparo; //
                receitas.Status = true;
                database.Receitas.Add(receitas);
                database.SaveChanges();
                return RedirectToAction("Receitas","Gestao");
            }else {
                
                return View("../Gestao/NovaReceita");
            }
        }
        public IActionResult Atualizar(ReceitaDTO receitasTemporaria) {
            if(ModelState.IsValid) {
                var receita = database.Receitas.First(cat => cat.Id == receitasTemporaria.Id);
                receita.Nome = receitasTemporaria.Nome;
                receita.TempoPreparo = receitasTemporaria.TempoPreparo;
                receita.ModoPreparo = receitasTemporaria.ModoPreparo;
                database.SaveChanges();
                return RedirectToAction("Receitas","Gestao");
            }else {
                return View("../Gestao/EditarReceita");
            }
        }
        [HttpPost]
        public IActionResult Deletar(int id){
            if(id> 0){
                var receita = database.Receitas.First(cat => cat.Id == id);
                receita.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Receitas","Gestao");
        }
    }
}