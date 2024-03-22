using System.Numerics;
using Raylib_cs;

namespace Shooter {

    public static class GameController {

        public static void StartGame(ref Context ctx) {

            PlaneEntity plane = new PlaneEntity();
            plane.pos = new Vector2(400, 300);
            plane.speed = 50;
            plane.radius = 20;
            plane.color = Color.Yellow;

            ctx.plane = plane;

        }

    }
}