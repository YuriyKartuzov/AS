using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ActorStudio.Controllers
{

    public class VocalAddForm
    {

        public VocalAddForm()
        {
            LastModified = DateTime.Now;
        }

        [Required]
        public string Title { get; set; }

        [DisplayName("Description")]
        public string Descr { get; set; }

        [DisplayName("Last modified")]
        public DateTime LastModified { get; set; }

        //[Required]
        [Display(Name = "Image")]
        [DataType(DataType.Upload)]
        public string PhotoUpload { get; set; }

        [Display(Name = "Text")]
        [DataType(DataType.Upload)]
        public string TextUpload { get; set; }

        [Display(Name = "Video")]
        [DataType(DataType.Upload)]
        public string VideoUpload { get; set; }

        [Display(Name = "Audio")]
        [DataType(DataType.Upload)]
        public string AudioUpload { get; set; }
    }

    public class VocalAdd
    {
        public VocalAdd()
        {
            LastModified = DateTime.Now;
        }

        [Required]
        public string Title { get; set; }

        [DisplayName("Description")]
        public string Descr { get; set; }

        [DisplayName("Last modified")]
        public DateTime LastModified { get; set; }

        public HttpPostedFileBase PhotoUpload { get; set; }

        public HttpPostedFileBase TextUpload { get; set; }

        public HttpPostedFileBase VideoUpload { get; set; }

        public HttpPostedFileBase AudioUpload { get; set; }

    }

    public class VocalBase
    {
        public VocalBase()
        {
            LastModified = DateTime.Now;
        }

        [Required]
        public string Title { get; set; }

        [DisplayName("Description")]
        public string Descr { get; set; }

        [DisplayName("Last modified")]
        public DateTime LastModified { get; set; }

        public int Id { get; set; }
        public bool audioB { get; set; }
        public bool txtB { get; set; }
        public bool videoB { get; set; }
        public bool imageB { get; set; }

        [Display(Name = "Text")]
        public string TextUrl
        {
            get
            {
                return $"/text/{Id}";
            }
        }

        [Display(Name = "Image")]
        public string PhotoUrl
        {
            get
            {
                return $"/photo/{Id}";
            }
        }

        [Display(Name = "Audio")]
        public string AudioUrl
        {
            get
            {
                return $"/audio/{Id}";
            }
        }

        [Display(Name = "Video")]
        public string VideoUrl
        {
            get
            {
                return $"/video/{Id}";
            }
        }

        [StringLength(200)]
        public string TextContentType { get; set; }

        [StringLength(200)]
        public string PhotoContentType { get; set; }

        [StringLength(200)]
        public string AudioContentType { get; set; }

        [StringLength(200)]
        public string VideoContentType { get; set; }
    }


    public class VocalEditForm
    {

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [DisplayName("Description")]
        public string Descr { get; set; }
    }

    public class VocalDeleteForm
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [DisplayName("Description")]
        public string Descr { get; set; }
    }

    public class VocalText
    {
        public int Id { get; set; }
        public string TextContentType { get; set; }
        public byte[] Text { get; set; }
    }

    public class VocalPhoto
    {
        public int Id { get; set; }
        public string PhotoContentType { get; set; }
        public byte[] Photo { get; set; }
    }

    public class VocalAudio
    {
        public int Id { get; set; }
        public string AudioContentType { get; set; }
        public byte[] Audio { get; set; }
    }

    public class VocalVideo
    {
        public int Id { get; set; }
        public string VideoContentType { get; set; }
        public byte[] Video { get; set; }
    }




}