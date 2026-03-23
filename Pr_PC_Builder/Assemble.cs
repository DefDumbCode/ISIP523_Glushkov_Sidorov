using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_PC_Builder
{
    internal class Assemble
    {
        public List<basepart_> partlist = new List<basepart_> 
        {
            new basepart_ { id = 100, name = "Пусто", manufacturerid = 100, parttypeid = 1, image = , price = 0},
            new basepart_ {}, 
            new basepart_ {},
            new basepart_ {},
            new basepart_ {},
            new basepart_ {},
            new basepart_ {},
            new basepart_ {}
        };

        //лист в классе, из которого будут делаться 2 экземпляра: 1 для сборки, 2 статичный 
        //в классе должны быть описаны методы для работы с деталями, по типу выбора, замены, удаления

    }
}
