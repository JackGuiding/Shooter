using System.Numerics;
using Raylib_cs;

namespace Shooter {

    public static class GameController {

        public static void StartGame(Context ctx) {

            // new 相当于通过设计图创建一个实例(实物)
            PlaneEntity playerPlane = new PlaneEntity();
            playerPlane.id = 1;
            playerPlane.pos = new Vector2(400, 300);
            playerPlane.speed = 50;
            playerPlane.radius = 20;
            playerPlane.color = Color.Yellow;

            ctx.playerPlaneID = playerPlane.id; // 记录玩家的飞机ID
            // 调用添加
            ctx.planeRepository.Add(playerPlane);

        }

    }
}