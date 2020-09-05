using System;
using Blazor.Extensions.Canvas.Canvas2D;

namespace BlazorPong
{
    public class Ball: Entity
    {
        public override void Update()
        {
            
        }

        public override async void Draw(Canvas2DContext batch)
        {
            await batch.SetFillStyleAsync("green");
            await batch.ArcAsync(95, 50, 40, 0, 2 * Math.PI);
            await batch.StrokeAsync();
        }
    }
}