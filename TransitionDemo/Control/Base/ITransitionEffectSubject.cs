using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitionDemo.Control
{
    public interface ITransitionEffectSubject
    {
        string MatrixTransformName { get; }
        string RotateTransformName { get; }
        string ScaleTransformName { get; }
        string SkewTransformName { get; }
        string TranslateTransformName { get; }
        TimeSpan Offset { get; }
    }
}
