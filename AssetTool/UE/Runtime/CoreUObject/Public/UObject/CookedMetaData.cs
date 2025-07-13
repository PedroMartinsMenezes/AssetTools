namespace AssetTool
{
    [JsonAsset("EnumCookedMetaData")]
    public class UEnumCookedMetaData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("StructCookedMetaData")]
    public class UStructCookedMetaData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ClassCookedMetaData")]
    public class UClassCookedMetaData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}