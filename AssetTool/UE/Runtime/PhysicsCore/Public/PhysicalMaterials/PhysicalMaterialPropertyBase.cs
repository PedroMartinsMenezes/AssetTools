namespace AssetTool
{
    [JsonAsset("PhysicalMaterialPropertyBase")]
    public class UDEPRECATED_PhysicalMaterialPropertyBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}