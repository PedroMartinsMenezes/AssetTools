using AssetTool.Model;

namespace AssetTool
{
    public class AssetObject
    {
        public long Offset;
        public string Type;
        public UObject Obj;

        public T Get<T>() where T : new()
        {
            T obj = new T();
            Obj = obj as UObject;
            return obj;
        }
    }
}
