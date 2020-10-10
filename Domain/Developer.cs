using System;

namespace Domain
{
    //Now, let’s add the Required Entities to the Domain Project. Create a new Folder in the Domain Project named Entities.
    public class Developer
    {
        //Create 2 very simple classes – Developer and Project under the Entities Folder.

        public int Id { get; set; }
        public string Name { get; set; }
        public int Followers { get; set; }
    }
}
