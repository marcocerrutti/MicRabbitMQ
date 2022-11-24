using System;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingContext: DbContext
    {
        public BankingContext(DbContextOptions options) : base(options)
        {

        }
    }
}

