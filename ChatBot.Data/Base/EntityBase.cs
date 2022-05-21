using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Data.Base
{
    public class EntityBase : IEquatable<EntityBase>
    {
        public int Id { get; init; }

        public bool Equals(EntityBase? other)
        {
            return other!.Id == Id;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((EntityBase) obj);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
