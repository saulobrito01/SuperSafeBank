﻿using System;
using MediatR;
using SuperSafeBank.Web.API.Queries.Models;

namespace SuperSafeBank.Web.API.Queries
{
    public class AccountById : IRequest<AccountDetails>
    {
        public AccountById(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}