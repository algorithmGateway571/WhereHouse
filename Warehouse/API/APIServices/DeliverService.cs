using System.Collections.Generic;
using System.Threading.Tasks;
using Warehouse.API.API_Models;

namespace Warehouse.API.APIServices
{
    public class DeliverService : IDeliverService
    {
        private readonly Request<DeliverModel> _deliverService;

        public DeliverService()
        {
            _deliverService = new Request<DeliverModel>("deliver");
        }
        public async Task<DeliverModel> CreateDeliver(DeliverModel deliverModel)
        {
            if (deliverModel != null)
            {
                DeliverModel deliver = await _deliverService.Post("", deliverModel);
                if (deliver != null) return deliver;
                return null;
            }
            return null;
        }

        public async Task<List<DeliverModel>> GetDelivers()
        {
            return await _deliverService.GetAll();
        }
    }

    public interface IDeliverService
    {
        Task<List<DeliverModel>> GetDelivers();
        Task<DeliverModel> CreateDeliver(DeliverModel deliverModel);
    }
}
