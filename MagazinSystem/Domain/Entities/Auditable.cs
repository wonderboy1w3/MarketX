using System;

namespace MagazinSystem.Domain.Entities
{
    public abstract class Auditable
    {
        public long Id { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdatedAt { get; internal set; }
    }
}
