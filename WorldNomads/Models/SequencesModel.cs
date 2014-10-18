using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldNomads.Lib;

namespace WorldNomads.Web.Models
{
    public class SequencesModel
    {
        public IEnumerable<Sequence<uint>> Sequences { get; set; }

        public string Error { get; set; }

        public bool IsValid { get { return string.IsNullOrWhiteSpace(Error); } }
    }
}