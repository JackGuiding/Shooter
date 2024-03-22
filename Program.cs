using System.Numerics;
using Raylib_cs;

namespace Shooter {

    public static class Program {

        public static void Main() {

            // 类型 [], 就是该类型的数组
            int[] arr = new int[100];
            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 2;

            for (int i = 0; i < 100; i++) {
                arr[i] = i;
            }

            // 所有的数据都在 Context 里
            Context ctx = new Context();

            GameController.StartGame(ctx);

            Raylib.InitWindow(800, 600, "Hello World");

            while (!Raylib.WindowShouldClose()) {

                // 开始绘制
                Raylib.BeginDrawing();

                // 画背景
                Raylib.ClearBackground(Color.RayWhite);

                // 查找飞机
                PlaneEntity plane = ctx.planeRepository.Get(ctx.playerPlaneID);

                // 画飞机
                Raylib.DrawCircleV(plane.pos, plane.radius, plane.color);

                // 结束绘制
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();

        }

    }
}