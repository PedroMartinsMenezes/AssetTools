using AssetTool.Model.Basic;

namespace AssetTool.Model
{
    public class FDeserializePackageData
    {
        public Int64 DependencyDataOffset; //2765
        public Int32 ObjectCount; //1
    }

    public class FDeserializeObjectPackageData
    {
        public FString ObjectPath;
        public FString ObjectClassName;
        public Int32 TagCount; //1
    }

    public class FDeserializeTagData
    {
        public FString Key; //Tooltip
        public FString Value; //null (Empty)
    }
}
