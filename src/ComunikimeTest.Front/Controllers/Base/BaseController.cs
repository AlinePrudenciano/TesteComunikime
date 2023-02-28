using AutoMapper;
using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Interfaces.Services;
using ComunikimeTest.Front.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace ComunikimeTest.Front.Controllers
{
    public class BaseController<TEntity, TModel> : Controller where TEntity : BaseEntity where TModel : BaseModel
    {
        private readonly IService<TEntity> _service;
        private readonly IMapper _mapper;

        public BaseController(IService<TEntity> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: OrderItemModels
        public async Task<ActionResult> Index()
        {
              return View(await _service.Get(CancellationToken.None));
        }

        // GET: OrderItemModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null || await _service.Get(id.Value, CancellationToken.None) == null)
            {
                return NotFound();
            }

            var model = await _service.Get(id.Value, CancellationToken.None);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // GET: OrderItemModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderItemModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(TModel model)
        {
            if (ModelState.IsValid)
            {
                await _service.Add(_mapper.Map<TEntity>(model), CancellationToken.None);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: OrderItemModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null || await _service.Get(id.Value, CancellationToken.None) == null)
            {
                return NotFound();
            }

            var model = await _service.Get(id.Value, CancellationToken.None);

            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        // POST: OrderItemModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, TModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _service.Update(_mapper.Map<TEntity>(model), id, CancellationToken.None);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await OrderItemModelExists(model.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: OrderItemModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null || await _service.Get(id.Value, CancellationToken.None) == null)
            {
                return NotFound();
            }

            var model = await _service.Get(id.Value, CancellationToken.None);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: OrderItemModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            if (await _service.Get(id, CancellationToken.None) == null)
            {
                return Problem("Entity set 'ComunikimeTestMvcContext.OrderItemModel'  is null.");
            }
            var model = await _service.Get(id, CancellationToken.None);
            if (model != null)
            {
                await _service.Delete(id, CancellationToken.None);
            }
            
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> OrderItemModelExists(int id)
        {
            return (await _service.Get(id, CancellationToken.None)) != null;
        }
    }
}
