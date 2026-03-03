using DatabaseMastery.TransportMongoDb.Dtos.ShipmentDtos;

namespace DatabaseMastery.TransportMongoDb.Services.ShipmentServices
{
    public interface IShipmentService
    {
        Task<List<ResultShipmentDto>> GetAllShipmentAsync();
        Task CreateShipmentAsync(CreateShipmentDto createShipmentDto);
        Task UpdateShipmentAsync(UpdateShipmentDto updateShipmentDto);
        Task<GetShipmentByIdDto> GetShipmentByIdAsync(string id);
        Task DeleteShipmentAsync(string id);
        Task<GetShipmentByIdDto> GetShipmentByTrackingNumberAsync(string trackingNumber);
        public Task<long> GetTotalShipmentCountAsync();
        public Task<long> GetDelirevedShipmentCountAsync();
        public Task<int> GetDiscintDestinationCityCountAsync();
        public Task<long> GetInDistributionShipmentCountAsync();
        
    }
}
