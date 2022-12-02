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
    public class ArticleManager : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ArticleManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult> Add(ArticleAddDto articleAddDto, string createdByName)
        {
            await _unitOfWork.Articles.AddAsync(new Article
            {
                Title=articleAddDto.Title,
                Content=articleAddDto.Content,
                Thumbnail=articleAddDto.Thumbnail,
                Date=articleAddDto.Date,
                SeoAuthor=articleAddDto.SeoAuthor,
                SeoDescription=articleAddDto.SeoDescription,
                IsActive=articleAddDto.IsActive,
                SeoTags=articleAddDto.SeoTags,
                CategoryId=articleAddDto.CategoryId,
                CreatedDate=DateTime.Now,
                CreatedByName=createdByName,
                ModifiedDate=DateTime.Now,
                ModifiedByName=createdByName,
                IsDeleted=false

            }).ContinueWith(t=>_unitOfWork.SaveAsync()); //Bu yazım daha performanslı çalışıyor. Aşağıdaki satıra göre
            //await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, $"{articleAddDto.Title} başlıklı makale başarıyla eklenmiştir.");
        }

        public Task<IResult> Delete(int articleId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<ArticleDto>> Get(int articleId)
        {
            var article = await _unitOfWork.Articles.GetAsync(a => a.Id == articleId, c => c.Category);
            if (article != null)
            {
                return new DataResult<ArticleDto>(ResultStatus.Success, new ArticleDto
                {

                    Article = article,
                    ResultStatus = ResultStatus.Success


                });
            }
            return new DataResult<ArticleDto>(ResultStatus.Error, "Hiç makale bulunamadı", null);
        }

    public async Task<IDataResult<ArticleListDto>> GetAll()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(null, a => a.Articles);
            if (articles.Count > 0)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto 
                { 
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hiç makale bulunamadı", null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeleted()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(a=>!a.IsDeleted, a=>a.Articles);
            if (articles.Count > 0)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto 
                { 
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hiç makale bulunamadı", null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAndActive()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(c => !c.IsDeleted && c.IsActive, a => a.Articles);
            if (articles.Count > 0)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hiç makale bulunamadı.", null);
        }

        public Task<IResult> HardDelete(int articleId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }
    }
}
