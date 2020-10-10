using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

// Next , we will setup and configure Entity Framework Core. Install these Required Packages in the DataAccess.EFCore Project. Here is where we would have our DbContect Class and the actual Implementations of the Repositories.