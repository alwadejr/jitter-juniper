﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jitter.Models
{
    public class JitterRepository
    {
        private JitterContext _context;
        public JitterContext Context { get { return _context; } }
        public JitterRepository()
        {
            _context = new JitterContext();

        }

        public JitterRepository(JitterContext a_context)
        {
            _context = a_context;
        }

        public List<>
    }
}
