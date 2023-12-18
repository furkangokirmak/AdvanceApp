using AutoMapper;

namespace AdvanceAPI.BLL.Mapper
{
    public class MyMapper
    {
        private readonly IMapper _mapper;

        public MyMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MapperProfile>();
            });

            _mapper = config.CreateMapper();
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TSource, TDestination>(source);
        }
    }
}
