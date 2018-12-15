using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ActorStudio.Models
{

    public class VocalClass
    {
        public VocalClass()
        {
            LastModified = DateTime.Now;
            audioB = false;
            txtB = false;
            videoB = false;
            imageB = false;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descr { get; set; }
        public DateTime LastModified { get; set; }
        public bool audioB { get; set; }
        public bool txtB { get; set; }
        public bool videoB { get; set; }
        public bool imageB { get; set; }

        [StringLength(200)]
        public string PhotoContentType { get; set; }
        public byte[] Photo { get; set; }

        [StringLength(200)]
        public string AudioContentType { get; set; }
        public byte[] Audio { get; set; }

        [StringLength(200)]
        public string TextContentType { get; set; }
        public byte[] Text { get; set; }

        [StringLength(200)]
        public string VideoContentType { get; set; }
        public byte[] Video { get; set; }


    }


    public class DanceClass
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }


    public class ActingClass
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }


}