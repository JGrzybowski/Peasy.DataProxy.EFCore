﻿using AutoMapper;

namespace Peasy.DataProxy.EFCore
{
    public class AutoMapperHelper : IMapper
    {
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return Mapper.Map<TDestination>(source);
        }

        public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return Mapper.Map<TSource, TDestination>(source, destination);
        }
    }
}