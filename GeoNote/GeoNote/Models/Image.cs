namespace GeoNote.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Image
    {
        public int? ImageId { get; set; }

        public string ImageName { get; set; }

        public int? AlbumId { get; set; }

        public string JiraId { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }

        public string Notes { get; set; }

        public bool IsAlbum { get; set; }

        public DateTime DateUploaded { get; set; }

        public int? CameraId { get; set; }
    }
}