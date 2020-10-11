using DataAccess.EFCore.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    /*
     * The other major advantage is that, multiple repository objects will have different instances of dbcontext within them. 
     * This can lead to data leaks in complex cases.
     * Let’s say that you have a requirement to insert a new Developer and a new Project within the same transaction. 
     * What happens when the new Developer get’s inserted but the Project Repository fails for some reason. 
     * In real-world scenarios, this is quite fatal. 
     * We will need to ensure that both the repositories work well, before commiting any change to the database. 
     * This is exactly why we decided to not include SaveChanges in any of the repostories. Clear?
     * 
     * Rather, the SaveChanges will be available in the UnitOfWork Class. 
     * You will get a better idea once you see the impelemntation.
     * 
     * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
     * 
     * There are no save methos in repositories..
     * Coz, we have to make sure that repositories work well, before commiting to database
     * So we implemented a UNITOFWORK Pattern
     */

        // this function save save changes to database
    public interface IUnitOfWork : IDisposable
    {
        IDeveloperRepository Developers { get; }
        IProjectRepository Projects { get; }
        int Complete();
    }
}
