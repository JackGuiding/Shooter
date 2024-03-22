using System.Numerics;
using Raylib_cs;

namespace Shooter {

    public struct PlaneEntity {

        // 成员字段
        public int id;
        public Vector2 pos;
        public float speed;

        public float radius;
        public Color color;

        // 成员函数/成员方法
        public void Move(Vector2 moveDir) {

            // Eg:1
            moveDir = moveDir * speed;

            // Eg:2
            // moveDir.X = moveDir.X * speed;
            // moveDir.Y = moveDir.Y * speed;

            pos = pos + moveDir;

        }

    }

}