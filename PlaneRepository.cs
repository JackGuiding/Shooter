using System.Collections.Generic;

namespace Shooter {

    // 飞机仓库(增/删/查)
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

        // 查找飞机
        public PlaneEntity Get(int id) {
            PlaneEntity result = null;
            // 遍历所有飞机
            for (int i = 0; i < count; i += 1) {
                PlaneEntity exist = planes[i];
                // 找到ID相同的飞机
                if (exist.id == id) {
                    result = exist;
                    break; // 结束 for, 中断循环
                }
            }
            return result;
        }

        // 删除飞机
        public void Remove(PlaneEntity toBeRemoved) {
            // 遍历所有飞机
            for (int i = 0; i < count; i++) {
                // 在飞机里找到要删除的飞机, id 相同的
                PlaneEntity exist = planes[i];
                if (exist.id == toBeRemoved.id) {
                    planes[i] = planes[count - 1];
                    count--; // count = count - 1;
                    break; // 结束 for, 中断循环
                }
            }
        }

    }

}