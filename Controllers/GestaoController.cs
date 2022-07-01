using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlazorInputFile;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VirtualMagazine.Data;
using VirtualMagazine.DTO;

namespace VirtualMagazine.Controllers
{   
    [Authorize(Policy="emailAutorizado")]
    public class GestaoController : Controller
    {   
        
        private readonly ApplicationDbContext database;

        public GestaoController(ApplicationDbContext database) {
            this.database = database;
        }

        public IActionResult Index() {
            var receitas = database.Receitas.Where(cat => cat.Status == true).ToList();
            return View(receitas);
        }
        public IActionResult Receitas() {
            var receitas = database.Receitas.Where(cat => cat.Status == true).ToList();
            return View(receitas);
        }
        

        public IActionResult NovaReceita() {
            return View();
        }
        public IActionResult EditarReceita(int id) {
            var receita= database.Receitas.First(cat => cat.Id == id);
            ReceitaDTO receitaView = new ReceitaDTO();
            receitaView.Id = receita.Id;
            receitaView.Nome = receita.Nome;
            receitaView.ModoPreparo = receita.ModoPreparo;
            receitaView.TempoPreparo = receita.TempoPreparo; 
            return View(receitaView);
        }
        public IActionResult UnidadeDeMedidas() {
            var unidadeDeMedida = database.UnidadeDeMedidas.Where(cat => cat.Status == true).ToList();
            return View(unidadeDeMedida);
        }
        public IActionResult NovaUnidadeDeMedida() {
            ViewBag.Receitas = database.Receitas.ToList();
            return View();
        }
        public IActionResult EditarUnidadeDeMedida(int id) {
            var unidadeDeMedida = database.UnidadeDeMedidas.First(forne => forne.Id == id);
            IgredienteDTO unidadeDeMedidaView = new IgredienteDTO();
            unidadeDeMedidaView.Id = unidadeDeMedida.Id;
            unidadeDeMedidaView.Nome = unidadeDeMedida.Nome;
            return View(unidadeDeMedidaView);
        }
        public IActionResult Igredientes() {
            var igredientes = database.Igredientes.Include(p => p.Receita).Include(p => p.UnidadeDeMedida).Where(p => p.Status ==true).ToList();
            return View(igredientes);
        }
        public IActionResult NovoIgrediente() {
            ViewBag.Receitas = database.Receitas.ToList();
            ViewBag.UnidadeDeMedidas = database.UnidadeDeMedidas.ToList();
            return View();
        }
        public IActionResult EditarIgrediente(int id) {
            var igrediente = database.Igredientes.Include(p => p.Receita).Include(p => p.UnidadeDeMedida).First(p => p.Id == id);
            UnidadeDeMedidaDTO igredienteView = new UnidadeDeMedidaDTO();
            igredienteView.Id = igrediente.Id;
            igredienteView.Nome = igrediente.Nome;
            igredienteView.Medicao = igrediente.Medicao;
            ViewBag.Receitas = database.Receitas.ToList();
            ViewBag.UnidadeDeMedidas = database.UnidadeDeMedidas.ToList();
            return View(igredienteView);
        }   
        public IActionResult ReceitasProntas(){
            ViewBag.UnidadeDeMedidas = database.UnidadeDeMedidas.ToList();
            var receitas = database.Receitas.Where(cat => cat.Status == true).ToList();
            return View(receitas);
        }
        public IActionResult ItensReceitas(){
             var igredientes = database.Igredientes.Include(p => p.Receita).Include(p => p.UnidadeDeMedida).Where(p => p.Status ==true).ToList();
            return View(igredientes);
        }
        public IActionResult Front(){
            
            var receitas = database.Receitas.Where(cat => cat.Status == true).ToList();
            
            return View(receitas);
        }
        
        
    }
}