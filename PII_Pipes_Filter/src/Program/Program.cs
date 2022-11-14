using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;
using TwitterUCU;
using CognitiveCoreUCU;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture("beer.jpg");
            ConvultionType boxblur = new ConvultionType(3, 9, 0);
                               
            IPipe pipeNull = new PipeNull();
            IPipe pipeNegative = new PipeSerial(new FilterConvolution(boxblur), pipeNull);
            IPipe pipeTwitter = new PipeSerial(new FilterTwitter(), pipeNull);
            IPipe pipeConditional = new PipeFork(new FilterConditionalFace(), pipeTwitter, pipeNegative);
            IPipe pipeResult = new PipeSerial(new FilterResult(), pipeConditional);
            IPipe pipeGray = new PipeSerial( new FilterGreyscale(), pipeResult);
            picture = pipeGray.Send(picture);
 
            provider.SavePicture(picture, "PICTURE.jpg");


        }
    }
}
