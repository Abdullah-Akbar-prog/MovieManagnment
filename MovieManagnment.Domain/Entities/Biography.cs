﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagnment.Domain.Entities
{
    public class Biography
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
