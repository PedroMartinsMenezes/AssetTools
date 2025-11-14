namespace AssetTool
{
    [JsonAsset("EnumCookedMetaData")]
    public class UEnumCookedMetaData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("StructCookedMetaData")]
    public class UStructCookedMetaData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ClassCookedMetaData")]
    public class UClassCookedMetaData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}