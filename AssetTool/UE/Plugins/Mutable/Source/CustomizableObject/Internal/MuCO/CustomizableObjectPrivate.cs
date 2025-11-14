namespace AssetTool
{
    [JsonAsset("ModelStreamableData")]
    public class UModelStreamableData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectBulk")]
    public class UCustomizableObjectBulk : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectPrivate")]
    public class UCustomizableObjectPrivate : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}