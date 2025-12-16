using Assessment2.Application.Dtos;
using Assessment2.Domain;

namespace Assessment2.Application.Interfaces
{
    public interface IAnalyserService
    {
        ApiResponse<DecodeResponseDto> DecodeNumber(string phoneNumber);
    }
}
