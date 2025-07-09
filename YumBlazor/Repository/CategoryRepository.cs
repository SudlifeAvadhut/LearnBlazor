using Microsoft.EntityFrameworkCore;
using YumBlazor.Data;
using YumBlazor.Repository.IRepository;

namespace YumBlazor.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public ApplicationDbContext db { get; set; }
        public CategoryRepository(ApplicationDbContext _db)
        {
            this.db = _db;
        }
        public async Task<Category> CreateAsync(Category category)
        {
            await db.Categories.AddAsync(category);
            await db.SaveChangesAsync();
            return category;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var category = await db.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category == null)
            {
                return false; // Category not found
            }
            else
            {
                db.Categories.Remove(category);
                await db.SaveChangesAsync();
                return true;
            }
        }

        public async Task<Category> GetAsync(int id)
        {
            return await db.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await db.Categories.ToListAsync();
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            var objFromDb = await db.Categories.FirstOrDefaultAsync(c => c.Id == category.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;
                db.SaveChangesAsync();
                return objFromDb;
            }
            else
            {
                return null; // Category not found
            }
        }
    }
}
