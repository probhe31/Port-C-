using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2
{
    public class CollectionFactory
    {
        public static ICollection<String> getCollection(CollectionType collectionType)
        {
            switch (collectionType)
            {
                case CollectionType.List:
                    return new List<String>();
                case CollectionType.Hash:
                    return new HashSet<string>();
                default:
                    return new HashSet<String>();
            }
        }

    }
}
