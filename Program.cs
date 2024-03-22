using System.Numerics;
using Raylib_cs;

namespace Shooter {

    public static class Program {

        public static void Main() {

            // 所有的数据都在 Context 里
            Context ctx = new Context();

            GameController.StartGame(ref ctx);

            Raylib.InitWindow(800, 600, "Hello World");

            while (!Raylib.WindowShouldClose()) {

                // 开始绘制
                Raylib.BeginDrawing();

                // 画背景
                Raylib.ClearBackground(Color.RayWhite);

                // 画飞机
                Raylib.DrawCircleV(ctx.plane.pos, ctx.plane.radius, ctx.plane.color);

                // 结束绘制
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();

        }

    }
}