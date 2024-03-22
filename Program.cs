using Raylib_cs;

public static class Program
{

    public static void Main()
    {
        Raylib.InitWindow(800, 600, "Hello World");

        while(!Raylib.WindowShouldClose())
        {
            // 开始绘制
            Raylib.BeginDrawing();

            // 画背景
            Raylib.ClearBackground(Color.RayWhite);
            Raylib.DrawText("Hello, world!", 12, 12, 20, Color.Black);
            
            // 结束绘制
            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();

    }

}