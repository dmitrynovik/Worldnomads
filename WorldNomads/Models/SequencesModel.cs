using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldNomads.Web.Models
{
    public class SequencesModel
    {
        public SequencesModel(IEnumerable<IEnumerable<object>> input)
        {
            Sequences = input;
        }

        public IEnumerable<IEnumerable<object>> Sequences { get; set; }

        public string Error { get; set; }

        public bool IsValid { get { return string.IsNullOrWhiteSpace(Error); } }
    }
}