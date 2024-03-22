namespace Shooter {

    // 上下文, 用于存储游戏中的所有数据
    public class Context {

        // 玩家的输入
        // 所有飞机
        // 所有子弹
        // 所有场景里的石头
        // 所有 NPC
        // 所有游戏时间
        public int playerPlaneID;
        public PlaneRepository planeRepository;

        public Context() {
            planeRepository = new PlaneRepository();
        }

    }

}