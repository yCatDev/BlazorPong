using System.Threading.Tasks;
using Blazor.Extensions;
using Blazor.Extensions.Canvas.Canvas2D;
using Microsoft.AspNetCore.Components;

namespace BlazorPong
{
    public class Game: ComponentBase
    {
        private Canvas2DContext _context;
        private Ball _ball;
        
        protected BECanvasComponent _canvasReference;

        protected override void OnInitialized()
        {
            _ball = new Ball();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            _context = await _canvasReference.CreateCanvas2DAsync();
            _ball.Draw(_context);
        }
    }
}