﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompAndDel;


namespace CompAndDel.Pipes
{
    public class PipeFork : IPipe
    {
        protected IConditionalFilter filtro;
        IPipe next2Pipe;
        IPipe nextPipe;
        
        /// <summary>
        /// La cañería recibe una imagen, la clona y envìa la original por una cañeria y la clonada por otra.
        /// </summary>
        /// <param name="tipoFiltro">Tipo de filtro que se debe aplicar sobre la imagen. Se crea un nuevo filtro con los parametros por defecto</param>
        /// <param name="nextPipe">Siguiente cañeria con filtro</param>
        /// <param name="next2Pipe">Siguiente cañeria sin filtro</param>
        public PipeFork(IConditionalFilter filtro, IPipe nextPipe, IPipe next2Pipe) 
        {
            this.filtro = filtro;
            this.next2Pipe = next2Pipe;
            this.nextPipe = nextPipe;           
        }
        
        /// <summary>
        /// La cañería recibe una imagen, construye un duplicado de la misma, 
        /// y envía la original por una cañería y el duplicado por otra.
        /// </summary>
        /// <param name="picture">imagen a filtrar y enviar a las siguientes cañerías</param>
        public IPicture Send(IPicture picture)
        {
            if (this.filtro.Filter(picture))
            {
              return this.nextPipe.Send(picture);
            }
            else
            {
              return this.next2Pipe.Send(picture);
            }
        }
    }
}
