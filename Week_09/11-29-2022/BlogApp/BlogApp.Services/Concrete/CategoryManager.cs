using BlogApp.Data.Abstract;
using BlogApp.Entities.Concrete;
using BlogApp.Entities.Dtos;
using BlogApp.Services.Abstract;
using BlogApp.Shared.Utilities.Result.Abstract;
using BlogApp.Shared.Utilities.Result.Complex_Types;
using BlogApp.Shared.Utilities.Result.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Services.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName)
        {
            await _unitOfWork.Categories.AddAsync(new Category
            {
                Name = categoryAddDto.Name,
                Description= categoryAddDto.Description,
                IsActive=categoryAddDto.IsActive,
                CreatedByName=createdByName,
                CreatedDate=DateTime.Now,
                IsDeleted=false,
                ModifiedByName=createdByName,
                ModifiedDate=DateTime.Now,
                Note=categoryAddDto.Note
            }).ContinueWith(t=>_unitOfWork.SaveAsync());

            return new Result(ResultStatus.Success, $"{categoryAddDto.Name} adlı kategori başarıyla eklenmiştir.");
        }

        public Task<IResult> Delete(int categoryId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<CategoryDto>> Get(int categoryId)
        {
            var category = await _unitOfWork.Categories.GetAsync(c=>c.Id==categoryId, c=>c.Articles);
            if (category != null) //eğer kategori başka bir kullanıcı tarafından 1ms önce silinmişse category null olur
            { //aranan kategori bulunduysa
                return new DataResult<CategoryDto>(ResultStatus.Success, new CategoryDto 
                {
                    Category = category,
                    ResultStatus = ResultStatus.Success
                });
            }
            //else etmeye gerek yok return etmediyse zaten aşağıya inecek.
            return new DataResult<CategoryDto>(ResultStatus.Error, "Böyle bir kategori bulunamadı.", null);
        }

        public async Task<IDataResult<CategoryListDto>> GetAll()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(null, c=>c.Articles);
            if (categories.Count > 0)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto 
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç kategori bulunamadı!", null);
        }

        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeleted()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(c=>!c.IsDeleted, c=>c.Articles);
            if (categories.Count > 0)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç kategori bulunamadı.", null);
        }

        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActive()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(c => !c.IsDeleted && c.IsActive, c=>c.Articles);
            if (categories.Count > 0)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }
        return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç kategori bulunamadı.", null);

        }

        public Task<IResult> HardDelete(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }
    }
}
