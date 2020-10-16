using Emissora.Aplication.AppEmissora.Input;
using Emissora.Aplication.AppEmissora.Interface;
using Emissora.Domain.Entities;
using Emissora.Domain.Interfaces.Repositories;
using Marraia.Notifications.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emissora.Aplication.AppEmissora
{
    public class ElencoAppServices : IElencoAppServices
    {
        private readonly IElencoRepository _elencoRepository;
        private readonly ISmartNotification _notification;

        public ElencoAppServices(ISmartNotification notification,
                                 IElencoRepository elencoRepository)
        {
            _elencoRepository = elencoRepository;
            _notification = notification;
        }

        public IEnumerable<Elenco> Get()
        {
            throw new NotImplementedException();
        }

        public Elenco GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Elenco Insert(Elencoinput usuario)
        {
            throw new NotImplementedException();
        }

        Elenco IElencoAppServices.Insert(Elencoinput usuario)
        {
            throw new NotImplementedException();
        }
    }
}
