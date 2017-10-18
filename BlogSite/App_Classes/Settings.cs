using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Web;

namespace BlogSite.App_Classes
{
    public class Settings
    {
        public static Size SmallImage
        {
            get
            {
                Size image = new Size();
                image.Width = Convert.ToInt32(ConfigurationManager.AppSettings["sw"]);
                image.Height= Convert.ToInt32(ConfigurationManager.AppSettings["sh"]);
                return image;
            }
        }

        public static Size MediumImage
        {
            get
            {
                Size image = new Size();
                image.Width = Convert.ToInt32(ConfigurationManager.AppSettings["mw"]);
                image.Height = Convert.ToInt32(ConfigurationManager.AppSettings["mh"]);
                return image;
            }
        }


        public static Size AuthorImageSize
        {
            get
            {
                Size image = new Size();
                image.Width = Convert.ToInt32(ConfigurationManager.AppSettings["author"]);
                image.Height = Convert.ToInt32(ConfigurationManager.AppSettings["author"]);
                return image;
            }
        }
    }
}