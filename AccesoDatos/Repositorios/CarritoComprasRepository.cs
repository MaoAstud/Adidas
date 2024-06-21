using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using AccesoDatos.Interfaces;
using System.Data.Entity;
using System.Linq;

namespace AccesoDatos.Repositories
{
    public class CarritoComprasRepository : ICarritoComprasRepository
    {
        
            private readonly adidasEntities _context;

            public CarritoComprasRepository()
            {
                _context = new adidasEntities();
            }

            public IEnumerable<CarritoCompras> GetCarritos()
            {
                return _context.CarritoCompras.ToList();
            }

            public CarritoCompras GetCarrito(int id)
            {
                return _context.CarritoCompras.Find(id);
            }

            public void AddCarrito(CarritoCompras carrito)
            {
                _context.CarritoCompras.Add(carrito);
                _context.SaveChanges();
            }

            public void UpdateCarrito(CarritoCompras carrito)
            {
                _context.Entry(carrito).State = EntityState.Modified;
                _context.SaveChanges();
            }

            public void DeleteCarrito(int id)
            {
                var carrito = _context.CarritoCompras.Find(id);
                if (carrito != null)
                {
                    _context.CarritoCompras.Remove(carrito);
                    _context.SaveChanges();
                }
            }
        }
    }