using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitionDemo.Control
{
    public interface IZIndexController
    {
        void Stack(params TransitionerSlide[] highestToLowest);
    }
}
