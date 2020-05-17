using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterBot.DTO
{
    public class TagDTO
    {
 
            [Required(ErrorMessage = "O campo {0} é obrigatório")]
            public string Tag { get; set; }

    }
}
