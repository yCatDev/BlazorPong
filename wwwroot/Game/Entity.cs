using Blazor.Extensions.Canvas.Canvas2D;

namespace BlazorPong
{
    public abstract class Entity
    {
        public abstract void Update();

        public virtual async void Draw(Canvas2DContext batch)
        {
            
        }
    }
}