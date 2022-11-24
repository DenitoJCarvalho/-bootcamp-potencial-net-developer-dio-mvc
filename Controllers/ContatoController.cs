using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bootcamp_potencial_net_developer_dio_mvc.Context;

namespace bootcamp_potencial_net_developer_dio_mvc.Controllers
{
  public class ContatoController : Controller
  {
    private readonly bootcamp_potencial_net_developer_dio_mvc.Context.Context _context;

    public ContatoController(
        bootcamp_potencial_net_developer_dio_mvc.Context.Context context
    )
    {
      this._context = context;
    }

    #region Index
    public IActionResult Index()
    {
      var contatos = _context.Contatos.ToList();
      return View(contatos);
    }
    #endregion

    #region Criar
    public IActionResult Criar()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Criar(bootcamp_potencial_net_developer_dio_mvc.Models.Contato contato)
    {
      if (ModelState.IsValid)
      {
        _context.Contatos.Add(contato);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
      }
      else
      {
        return View(contato);
      }
    }

    #endregion

    #region Edição
    public IActionResult Editar(int Id)
    {
      var contato = _context.Contatos.Find(Id);

      if (contato == null)
      {
        return NotFound();
      }
      return View(contato);
    }

    [HttpPost]
    public IActionResult Editar(bootcamp_potencial_net_developer_dio_mvc.Models.Contato contato)
    {
      var contatoBanco = _context.Contatos.Find(contato.ID);
      contatoBanco.Nome = contato.Nome;
      contatoBanco.Telefone = contato.Telefone;
      contatoBanco.Ativo = contato.Ativo;

      _context.Contatos.Update(contatoBanco);
      _context.SaveChanges();

      return RedirectToAction(nameof(Index));
    }
    #endregion

    #region Detalhes
    public IActionResult Detalhes(int Id)
    {
      var contato = _context.Contatos.Find(Id);

      if (contato is null)
      {
        return RedirectToAction(nameof(Index));
      }
      else
      {
        return View(contato);
      }
    }
    #endregion

    #region Deletar
    public IActionResult Deletar(int Id)
    {
      var contato = _context.Contatos.Find(Id);

      if (contato is null)
      {
        return RedirectToAction(nameof(Index));
      }
      else
      {
        return View(contato);
      }
    }
    #endregion
  }
}