using System;

namespace Agenda.Domain.Entities
{
    public abstract class ModelBase
    {
        public string Id { get; set; }

        public ModelBase()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
