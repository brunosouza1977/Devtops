using Emissora.Aplication.AppEmissora.Input;
using Emissora.Aplication.AppEmissora.Interface;
using Emissora.Domain.Entities;
using Emissora.Domain.Interfaces.Repositories;
using Marraia.Notifications.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emissora.Aplication
{

    public class ObraAppService : IObraAppService
    {
        private readonly IObraRepository _obraRepository;
        private readonly ISmartNotification _notification;

        public ObraAppService(ISmartNotification notification,
                                 IObraRepository obraRepository)
        {
            _obraRepository = obraRepository;
            _notification = notification;
        }

        public IEnumerable<Obra> Get()
        {
            throw new NotImplementedException();
        }

        public Obra GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Obra Insert(ObraInput usuario)
        {
            throw new NotImplementedException();
        }
    }
}
