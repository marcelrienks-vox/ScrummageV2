﻿using PieceOfCake.Data.Interfaces;
using PieceOfCake.Data.Models;

namespace PieceOfCake.Web.Test.DataAccess
{
    public class FakeUnitOfWork : IUnitOfWork
    {
        #region Properties

        public IRepository<Role> RoleRepository { get; private set; }
        public IRepository<User> UserRepository { get; private set; }

        #endregion

        public FakeUnitOfWork()
        {
            RoleRepository = new FakeRepository<Role>();
            UserRepository = new FakeRepository<User>();
        }
    }
}