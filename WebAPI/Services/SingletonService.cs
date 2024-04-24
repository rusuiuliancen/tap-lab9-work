﻿using WebAPI.Interfaces;

namespace WebAPI.Services
{
    public class SingletonService: ISingletonService
    {
        private readonly DateTime _instanceCreationDate;
        public SingletonService()
        {
            _instanceCreationDate = DateTime.Now;
        }

        public DateTime GetIntstanceCreationDate()
        {
            return _instanceCreationDate;
        }
    }
}
