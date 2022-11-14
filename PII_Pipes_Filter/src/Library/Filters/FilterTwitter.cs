using System.Drawing;
using System;
using TwitterUCU;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que recibe una imagen y la retorna en escala de grises.
    /// </remarks>
    public class FilterTwitter : IFilter
    {
        /// <summary>
        /// Un filtro que retorna la imagen recibida y envia la imagen a Twitter.
        /// </summary>
        /// <param name="image">La imagen a la cual se le va a aplicar el filtro.</param>
        /// <returns>La imagen recibida.</returns>
        public IPicture Filter(IPicture image)
        {
            IPicture result = image.Clone();

            var twitter = new TwitterImage();
            string path = "PICTURE.jpg";
            twitter.PublishToTwitter("Bienvenido!", path);

            return result;
        }
    }
}
