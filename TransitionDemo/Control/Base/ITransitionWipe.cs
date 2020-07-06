using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TransitionDemo.Control
{
    public interface ITransitionWipe
    {
        void Wipe(TransitionerSlide fromSlide, TransitionerSlide toSlide, Point origin, IZIndexController zIndexController);
    }
}
