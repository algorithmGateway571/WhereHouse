using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Warehouse.API.API_Models;

namespace Warehouse.API.APIServices
{
    public class ReceiveService : IReceiveService
    {
        private readonly Request<ReceiveModel> _receiveService;

        public ReceiveService()
        {
            _receiveService = new Request<ReceiveModel>("receive");
        }

        public async Task<ReceiveModel> CreateReceive(ReceiveModel receive)
        {
            if (receive != null)
            {
                ReceiveModel receiveModel = await _receiveService.Post("", receive);
                if (receiveModel != null) return receiveModel;
                else return null;
            }
            return null;
        }

        public async Task<List<ReceiveModel>> GetReceives()
        {
            return await _receiveService.GetAll();
        }

        public bool PetchReceive(int Id)
        {
            throw new NotImplementedException();
        }
    }

    public interface IReceiveService
    {
        Task<List<ReceiveModel>> GetReceives();
        Task<ReceiveModel> CreateReceive(ReceiveModel receive);
        bool PetchReceive(int Id);
    }
}
