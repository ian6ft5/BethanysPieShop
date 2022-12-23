﻿using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class PieRepository :IPieRepository
    {
        private readonly BethanysPieShopDbContext _bethanysPieShopDbContext;

        public PieRepository(BethanysPieShopDbContext bethanysPieShopDbContext)
        {
            _bethanysPieShopDbContext = bethanysPieShopDbContext;
        }
        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _bethanysPieShopDbContext.Pies.Include(c => c.Category).OrderBy(p => p.Name);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _bethanysPieShopDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek).OrderBy(p => p.Name);
            }
        }

        public Pie? GetPieById(int pieId)
        {
            return _bethanysPieShopDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
    
}

