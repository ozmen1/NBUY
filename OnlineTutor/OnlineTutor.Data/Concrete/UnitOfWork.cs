using OnlineTutor.Data.Abstract;
using OnlineTutor.Data.Concrete.EfCore.Contexts;
using OnlineTutor.Data.Concrete.EfCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OnlineTutorContext _context;

        public UnitOfWork(OnlineTutorContext context)
        {
            _context = context;
        }

        private EfCoreCategoryRepository _categoryRepository;
        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new EfCoreCategoryRepository(_context);

        public IShowCardRepository ShowCards => throw new NotImplementedException();

        public ITeacherRepository Teachers => throw new NotImplementedException();

        public ISubjectRepository Subjects => throw new NotImplementedException();

        public IStudentRepository Students => throw new NotImplementedException();

        public IRequestRepository Requests => throw new NotImplementedException();

        public ICommentRepository Comments => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
