using GridTest.Server.Models;
using GridTest.Server.Repositories;

namespace GridTest.Server.Services
{
    public class Service
    {
        private readonly Repository _repository;

        public Service()
        {
            _repository = new Repository();
        }

        public GridFormElement GetTestGrid(int rowCount) 
        {
            return _repository.GetGrid(rowCount);
        }
    }
}
