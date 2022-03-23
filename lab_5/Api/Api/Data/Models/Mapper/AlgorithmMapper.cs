using Api.Data.Models.DTO;

namespace Api.Data.Models.Mapper
{
    public class AlgorithmMapper
    {
        public static AlgorithmDTO? ConvertToDTO(Algorithms algorithms)
        {
            if (algorithms == null) return null;

            return new AlgorithmDTO(
                algorithms.Id,
                algorithms.Name,
                algorithms.Description,
                algorithms.Type,
                algorithms.Icon,
                algorithms.Url,
                algorithms.AlgorithmNickname
            );
        }
        public static Algorithms? ConvertToEntity(AlgorithmDTO algorithmDTO)
        {
            if (algorithmDTO == null) return null;

            return new Algorithms(
                algorithmDTO.Name,
                algorithmDTO.Description,
                algorithmDTO.Type,
                algorithmDTO.Icon,
                algorithmDTO.Url,
                algorithmDTO.AlgorithmNickname,
                true,
                DateTime.Now
                );
        }
    }
}
