using System.Drawing;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que recibe una imagen y la retorna.
    /// </remarks>
    public class FilterResult : IFilter
    {

        PictureProvider provider = new PictureProvider();

        /// <summary>
        /// Un filtro que retorna la imagen recibida y la guarda de forma local.
        /// </summary>
        /// <param name="image">La imagen a la cual se le va a aplicar el filtro.</param>
        /// <returns>La imagen recibida y guardada localmente.</returns>
        public IPicture Filter(IPicture image)
        {
            IPicture result = image.Clone();
            provider.SavePicture(image,"PICTURE.jpg");

            return result;
        }
    }
}
