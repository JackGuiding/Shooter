using System.Collections.Generic;

namespace Shooter {

    // 飞机仓库
    public class PlaneRepository {

        // 成员字段
        PlaneEntity[] planes;
        int count;

        public PlaneRepository() {
            planes = new PlaneEntity[1000];
            count = 0;
        }

        // 成员函数/成员方法

        // 添加飞机
        public void Add(PlaneEntity plane) {
            planes[count] = plane;
            count++; // count = count + 1;
        }

    }

}