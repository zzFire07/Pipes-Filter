using System;
using System.Drawing;
using CognitiveCoreUCU;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que recibe una imagen y retorna su negativo.
    /// </remarks>
    public class FilterConditionalFace : IConditionalFilter
    {
        /// Un filtro que retorna si una imagen tiene rostro o no.
        /// </summary>
        /// <param name="image">La imagen a la cual se le va a aplicar el filtro.</param>
        /// <returns>True si la foto tiene un rostro, false en el caso contrario.</returns>
        public bool Filter(IPicture image)
        {
        
        CognitiveFace cog = new CognitiveFace(false);
        cog.Recognize("PICTURE.jpg");



            return cog.FaceFound;
        }
    }
}
