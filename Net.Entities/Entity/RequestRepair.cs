using System;

namespace Net.Entities.Entity
{
    public class RequestRepair : BaseClass<long>
    {
        public RequestRepair()
        {
            ID = new long();
            Registered = DateTime.Now;
            IsActive = true;
            IsDelete = false;

        }


        public string RequestTitle { get; set; }

    }
}