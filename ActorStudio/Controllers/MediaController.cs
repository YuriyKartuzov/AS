using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActorStudio.Controllers
{
    public class MediaController : Controller
    {
        Manager m = new Manager();

        // GET: Getting Text For Vocal
        [Route("text/{id}")]
        public ActionResult GetVocalText(int id)
        {
            var o = m.VocalText(id);

            if (o == null)
                return HttpNotFound();
            else
            {
                var cd = new System.Net.Mime.ContentDisposition();
                Response.AppendHeader("Content-Disposition", cd.ToString());
                return File(o.Text, o.TextContentType);
            }
        }

        [Route("photo/{id}")]
        public ActionResult GetVocalPhoto(int? id)
        {
            var o = m.GetVocalPhoto(id.GetValueOrDefault());

            if (o == null)
                return HttpNotFound();
            else
            {
                var cd = new System.Net.Mime.ContentDisposition();
                Response.AppendHeader("Content-Disposition", cd.ToString());
                return File(o.Photo, o.PhotoContentType);
            }
        }

        [Route("audio/{id}")]
        public ActionResult GetVocalAudio(int? id)
        {
            var o = m.VocalAudio(id.GetValueOrDefault());

            if (o == null || o.Audio == null || o.AudioContentType == null)
                return HttpNotFound();
            else
            {
                return File(o.Audio, o.AudioContentType);
            }
        }


        [Route("video/{id}")]
        public ActionResult GetVocalVideo(int? id)
        {
            var o = m.VocalVideo(id.GetValueOrDefault());

            if (o == null || o.Video == null || o.VideoContentType == null)
                return HttpNotFound();
            else
            {
                return File(o.Video, o.VideoContentType);
            }
        }
    }
}