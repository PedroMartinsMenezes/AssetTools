namespace AssetTool
{
    [JsonAsset("MaterialInstanceConstant")]
    public class UMaterialInstanceConstant : UMaterialInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}